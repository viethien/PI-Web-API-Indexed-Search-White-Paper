/***************************************************************************
   Copyright 2015 OSIsoft, LLC.
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at
       http://www.apache.org/licenses/LICENSE-2.0
   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 ***************************************************************************/


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PISearchApp
{
    public enum QueryOptions { Name, Description, AFCategories, AFElementTemplate, AttributeName, AttributeDescription }

    public class PIWebAPISearchWrapper
    {
        public string Url = string.Empty;
        private string baseUrl = string.Empty;
        //Main constructor that requires the base url of PI Web API
        public PIWebAPISearchWrapper(string piWebApiBaseurl)
        {
            baseUrl = piWebApiBaseurl;
        }

        //Get string array with the available indexed sources (AF databases and PI Data Archives)
        public List<string> GetSources()
        {
            List<string> sourcesList = new List<string>();
            string url = baseUrl + "search/sources";
            dynamic result = MakeGetRequest(url);
            foreach (var item in result.Items)
            {
                sourcesList.Add(item.Name.Value);
            }
            return sourcesList;
        }

        //Query the crawled data by keywords. The inputs of the method are the inputs of the PI Web API correspondent action
        public Dictionary<string, dynamic> Search(string query, QueryOptions queryOption, string[] scope = null, string[] fields = null, int count = 10, int start = 0)
        {
            List<string> foundItems = new List<string>();
            string scopeQueryString = GenerateQueryString(scope, "scope");
            string fieldsQueryString = GenerateQueryString(fields, "fields");
            Url = baseUrl + "search/query?q=" + queryOption.ToString().ToLower() + ":" + query + scopeQueryString + fieldsQueryString + "&count=" + count + "&start=" + start;
            dynamic result = MakeGetRequest(Url);
            Dictionary<string, dynamic> dataDic = new Dictionary<string, dynamic>();
            foreach (dynamic item in result.Items)
            {
                dataDic.Add(item.Paths[0].Value,item);               
            }
            return dataDic;
        }

        //This private method generates the query string to be used on the URL for making HTTP request against PI Web API
        private string GenerateQueryString(string[] parameterArray, string parameterName)
        {
            string queryString = string.Empty;
            if ((parameterArray != null) && (parameterArray.Length > 0))
            {
                queryString = "&" + parameterName + "=";
                foreach (string item in parameterArray)
                {
                    queryString = queryString + item + ";";
                }
                queryString = queryString.Substring(0, queryString.Length - 1);
            }
            return queryString;
        }

        //This function is responsable for the HTTP GET request
        private dynamic MakeGetRequest(string url)
        {
            WebRequest request = WebRequest.Create(url);

            //If you are not using Anonymous for PI Web API authentication, then you need to provide your credentials.

            //Kerberos Authentication Only
            request.UseDefaultCredentials = true;


            WebResponse response = request.GetResponse();
            using (StreamReader sw = new StreamReader(response.GetResponseStream()))
            {
                //After storing the JSON response on the StreamReader sw object, we need to convert to a dynamic object.
                using (JsonTextReader reader = new JsonTextReader(sw))
                {
                    return JObject.ReadFrom(reader);
                }
            }
        }
    }
}
