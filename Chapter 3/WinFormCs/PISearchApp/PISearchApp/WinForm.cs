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


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PISearchApp
{
    public partial class WinForm : Form
    {
        private PIWebAPISearchWrapper piWebApi = null;
        private System.Windows.Forms.CheckBox[] checkBoxSources = null;
        private Dictionary<string, dynamic> dicData = null;
        public WinForm()
        {
            InitializeComponent();
            cbQueryOptions.DataSource = Enum.GetValues(typeof(QueryOptions));
            cbQueryOptions.SelectedIndex = 0;
            //Inicialize PI Web API Wrapper
            piWebApi = new PIWebAPISearchWrapper("https://marc-web-sql/piwebapi/");

            //Get PI Web API sources string array
            string[] sourceList = piWebApi.GetSources().ToArray();

            //Create the checkbox array for storing the checkboxes
            checkBoxSources = new System.Windows.Forms.CheckBox[sourceList.Count()];

            //Instantiate one checkbox per source
            int j = -1;
            int m = 0;
            for (int i = 0; i < checkBoxSources.Length; i++)
            {
                if (i < 42)
                {
                    checkBoxSources[i] = new System.Windows.Forms.CheckBox();
                    checkBoxSources[i].AutoSize = true;

                    //For each checkbox it needs to be added on a different location
                    checkBoxSources[i].Location = new System.Drawing.Point(20 + 300 * j, 5 + 20 * m);
                    checkBoxSources[i].Name = "cbSource" + i;
                    checkBoxSources[i].Size = new System.Drawing.Size(79, 17);
                    checkBoxSources[i].TabIndex = 0;
                    checkBoxSources[i].Text = sourceList[i];
                    checkBoxSources[i].UseVisualStyleBackColor = true;

                    //Add checkbox to the groupbox
                    this.gbDataSources.Controls.Add(checkBoxSources[i]);
                    if (i % 14 == 0)
                    {
                        j++;
                        m = 0;
                    }
                    m++;
                }
            }
        }

        //When the button is clicked, it will get data selected on the display and call the piWebAPI search action
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] fields = GetFieldsArray();
            string[] scope = GetSourceArray();
            int start = System.Convert.ToInt32(nudStart.Value);
            int count = System.Convert.ToInt32(nudCount.Value);
            string query = tbQuery.Text;
            var values = (QueryOptions[])Enum.GetValues(typeof(QueryOptions));
            QueryOptions queryOptions = (values)[cbQueryOptions.SelectedIndex];
            if (ValidateInputs() == true)
            {
                dicData = piWebApi.Search(query, queryOptions, scope, fields, count, start);
                tbUrl.Text = piWebApi.Url;
                lbResults.Items.Clear();
                lbResults.Items.AddRange(dicData.Keys.ToArray());
            }
        }

        //Private method used by the functions btnCopyJson_Click and btnViewJson_Click
        private void processSelectedItem(bool view)
        {
            if ((dicData == null) || (dicData.Keys.Count == 0))
            {
                MessageBox.Show("Please search for streams and make sure the results are not null");
            }
            else if (lbResults.SelectedItem == null)
            {
                MessageBox.Show("Please select an item first!");
            }
            else
            {
                string key = lbResults.SelectedItem.ToString();
                var jsonData = dicData[key];
                if (view == true)
                {
                    MessageBox.Show(this, jsonData.ToString(), "JSON response", MessageBoxButtons.OK);
                }
                else
                {
                    System.Windows.Forms.Clipboard.SetText(jsonData.ToString());
                }

            }
        }

        //When this button is clicked, it will copy the json response to the clipboard
        private void btnCopyJson_Click(object sender, EventArgs e)
        {
            processSelectedItem(false);
        }

        //When this button is clicked, it will display a message with the JSON response of the selected item
        private void btnViewJson_Click(object sender, EventArgs e)
        {
            processSelectedItem(true);
        }

        //Make sure the query field is not empty
        public bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(tbQuery.Text) == true)
            {
                MessageBox.Show("Query cannot be null or empty");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Get the status of the checkboxes from the WinForm and generate a string array with the selected sources
        private string[] GetSourceArray()
        {
            List<string> sourceList = new List<string>();
            for (int i = 0; i < checkBoxSources.Length; i++)
            {
                if (checkBoxSources[i].Checked == true)
                {
                    sourceList.Add(checkBoxSources[i].Text);
                }
            }

            if (sourceList.Count == 0)
            {
                return null;
            }
            else
            {
                return sourceList.ToArray();
            }
        }

        //Generate an string array according to state of each field checkbox 
        private string[] GetFieldsArray()
        {
            List<string> fieldsList = new List<string>();
            if (this.cbAttributes.Checked == true)
            {
                fieldsList.Add("attributes");
            }
            if (this.cbMatchedFields.Checked == true)
            {
                fieldsList.Add("matchedfields");
            }
            if (this.cbLinks.Checked == true)
            {
                fieldsList.Add("links");
            }
            if (this.cbItemType.Checked == true)
            {
                fieldsList.Add("itemtype");
            }
            if (this.cbHasChildren.Checked == true)
            {
                fieldsList.Add("haschildren");
            }
            if (this.cbEndTime.Checked == true)
            {
                fieldsList.Add("endtime");
            }
            if (this.cbDescription.Checked == true)
            {
                fieldsList.Add("description");
            }
            if (this.cbDataPipe.Checked == true)
            {
                fieldsList.Add("datatype");
            }
            if (this.cbWebID.Checked == true)
            {
                fieldsList.Add("webid");
            }
            if (this.cbUom.Checked == true)
            {
                fieldsList.Add("uom");
            }
            if (this.cbUniqueID.Checked == true)
            {
                fieldsList.Add("uniqueid");
            }
            if (this.cbTemplate.Checked == true)
            {
                fieldsList.Add("template");
            }
            if (this.cbStartTime.Checked == true)
            {
                fieldsList.Add("starttime");
            }
            if (this.cbPlottable.Checked == true)
            {
                fieldsList.Add("plottable");
            }
            if (this.cbName.Checked == true)
            {
                fieldsList.Add("name");
            }
            if (this.cbAFCateogory.Checked == true)
            {
                fieldsList.Add("afcategory");
            }
            fieldsList.Add("paths");
            return fieldsList.ToArray();

        }
    }
}
