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

$(document).ready(function () {

    //This function is responsable for all HTTP request against PI Web API using jQuery Ajax function.
    function getJsonData(url, successCallback) {
        $.ajax({
            type: "GET",
            url: url,
            cache: false,
            async: true,
            crossDomain: true,
            xhrFields: {
                withCredentials: true
            },
            success: successCallback,
            error: (function (error, variable) {
                console.log(error);
                alert('There was an error with the request');
            })
        });
    }

    //The autocomplete function from jQuery UI makes HTTP request to make query suggestions as soon as the user has typed 3 letters at least
    $("#foundstreams").autocomplete({
        delay: 500,
        minLength: 3,
        source: function (request, response) {
            var successCallback = function (data) {
                var formattedData = [];
                for (var i = 0; i < data.Items.length; i++) {
                    formattedData.push({ 'label': data.Items[i].ItemType + ": " + data.Items[i].Name, 'value': data.Items[i].WebID + "@@" + data.Items[i].ItemType });
                }
                response(formattedData);
            };
            var url = "https://marc-web-sql/piwebapi/search/query?q=" + request.term + "*";
            getJsonData(url, successCallback)
            $("#view-stream-info-btn").hide();
        },
        focus: function (event, ui) {
            // prevent autocomplete from updating the textbox
            event.preventDefault();
        },
        //this will be executed once the user selects a suggestion
        select: function (event, ui) {

            //// prevent autocomplete from updating the textbox
            event.preventDefault();
            //// navigate to the selected item's url
            //window.open(ui.item.url);
            $("#selected-webid").val(ui.item.value);
            $(this).val(ui.item.label);
            $("#view-stream-info-btn").show();
        }
    });


    //This function shows more information of the stream when the user clicks on the "View detailed stream info"
    $("#view-stream-info-btn")[0].onclick = function () {
        var identity = $("#selected-webid").val();
        var webId = identity.split("@@")[0];
        var itemtype = identity.split("@@")[1];
        //It checks if the selected item is a PI Point or an AF Elements and proceed according to it
        if (itemtype == "pipoint") {
            var url = "https://marc-web-sql/piwebapi/points/" + webId;
            console.log(url);
            var successCallback = function (data) {
                //render result on display
                var htmlCode = '<div><p>Is Future tag: ' + data.Future + '</p><p>PointID: ' + data.Id + ' </p><p>Name: ' + data.Name + ' </p><p>Point Class:  ' + data.PointClass + '</p><p>Point Type: ' + data.PointType + ' </p>PointType: ' + data.Future + '</p></div>';
                $('#item-content').html(htmlCode);
            };
            getJsonData(url, successCallback);
        }
        else if (itemtype == "afelement") {
            //If it is an element, it will get element information and the attributes list
            var urlElement = "https://marc-web-sql/piwebapi/elements/" + webId;
            console.log(urlElement);
            var successCallbackForElement = function (elementData) {
                var htmlCode = '<div><p>Name: ' + elementData.Name + '</p><p>Description: ' + elementData.Description + ' </p><p>Path: ' + elementData.Path + ' </p><p>Template Name:  ' + elementData.TemplateName + '</p></div>';
                $('#item-content').html(htmlCode);


                var urlAttributes = "https://marc-web-sql/piwebapi/elements/" + webId + "/attributes";
                var successCallbackForAttributes = function (attributesData) {
                    //render result on display
                    var attributeNames = '';
                    for (var i = 0; i < attributesData.Items.length; i++) {
                        attributeNames = attributeNames + attributesData.Items[i].Name + ", ";
                    }
                    if (attributeNames != '') {
                        attributeNames = attributeNames.substring(0, attributeNames.length - 2);
                    }
                    var htmlCode = '<div><p>Attributes: ' + attributeNames + '</p></div>';
                    $('#element-attributes').html(htmlCode);

                };
                getJsonData(urlAttributes, successCallbackForAttributes);
 

            };
            getJsonData(urlElement, successCallbackForElement);

        }        
    }


    //The "View detailed stream info" button starts hidden and it shows up after the user has selected an item 
    $("#view-stream-info-btn").hide();
});
