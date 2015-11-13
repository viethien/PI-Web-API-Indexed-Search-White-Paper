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

namespace PISearchApp
{
    partial class WinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.cbQueryOptions = new System.Windows.Forms.ComboBox();
            this.gbDataSources = new System.Windows.Forms.GroupBox();
            this.gbFields = new System.Windows.Forms.GroupBox();
            this.cbAttributes = new System.Windows.Forms.CheckBox();
            this.cbMatchedFields = new System.Windows.Forms.CheckBox();
            this.cbLinks = new System.Windows.Forms.CheckBox();
            this.cbItemType = new System.Windows.Forms.CheckBox();
            this.cbHasChildren = new System.Windows.Forms.CheckBox();
            this.cbEndTime = new System.Windows.Forms.CheckBox();
            this.cbDescription = new System.Windows.Forms.CheckBox();
            this.cbDataPipe = new System.Windows.Forms.CheckBox();
            this.cbWebID = new System.Windows.Forms.CheckBox();
            this.cbUom = new System.Windows.Forms.CheckBox();
            this.cbUniqueID = new System.Windows.Forms.CheckBox();
            this.cbTemplate = new System.Windows.Forms.CheckBox();
            this.cbStartTime = new System.Windows.Forms.CheckBox();
            this.cbPlottable = new System.Windows.Forms.CheckBox();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.cbAFCateogory = new System.Windows.Forms.CheckBox();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.btnViewJson = new System.Windows.Forms.Button();
            this.lbQuery = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lbUrl = new System.Windows.Forms.Label();
            this.btnCopyJson = new System.Windows.Forms.Button();
            this.gbFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(31, 29);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(333, 20);
            this.tbQuery.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(787, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(31, 594);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(672, 147);
            this.lbResults.TabIndex = 2;
            // 
            // cbQueryOptions
            // 
            this.cbQueryOptions.FormattingEnabled = true;
            this.cbQueryOptions.Location = new System.Drawing.Point(385, 28);
            this.cbQueryOptions.Name = "cbQueryOptions";
            this.cbQueryOptions.Size = new System.Drawing.Size(202, 21);
            this.cbQueryOptions.TabIndex = 3;
            // 
            // gbDataSources
            // 
            this.gbDataSources.Location = new System.Drawing.Point(31, 223);
            this.gbDataSources.Name = "gbDataSources";
            this.gbDataSources.Size = new System.Drawing.Size(831, 329);
            this.gbDataSources.TabIndex = 4;
            this.gbDataSources.TabStop = false;
            this.gbDataSources.Text = "Data Sources";
            // 
            // gbFields
            // 
            this.gbFields.Controls.Add(this.cbAttributes);
            this.gbFields.Controls.Add(this.cbMatchedFields);
            this.gbFields.Controls.Add(this.cbLinks);
            this.gbFields.Controls.Add(this.cbItemType);
            this.gbFields.Controls.Add(this.cbHasChildren);
            this.gbFields.Controls.Add(this.cbEndTime);
            this.gbFields.Controls.Add(this.cbDescription);
            this.gbFields.Controls.Add(this.cbDataPipe);
            this.gbFields.Controls.Add(this.cbWebID);
            this.gbFields.Controls.Add(this.cbUom);
            this.gbFields.Controls.Add(this.cbUniqueID);
            this.gbFields.Controls.Add(this.cbTemplate);
            this.gbFields.Controls.Add(this.cbStartTime);
            this.gbFields.Controls.Add(this.cbPlottable);
            this.gbFields.Controls.Add(this.cbName);
            this.gbFields.Controls.Add(this.cbAFCateogory);
            this.gbFields.Location = new System.Drawing.Point(31, 70);
            this.gbFields.Name = "gbFields";
            this.gbFields.Size = new System.Drawing.Size(831, 89);
            this.gbFields.TabIndex = 4;
            this.gbFields.TabStop = false;
            this.gbFields.Text = "Fields";
            // 
            // cbAttributes
            // 
            this.cbAttributes.AutoSize = true;
            this.cbAttributes.Location = new System.Drawing.Point(39, 59);
            this.cbAttributes.Name = "cbAttributes";
            this.cbAttributes.Size = new System.Drawing.Size(70, 17);
            this.cbAttributes.TabIndex = 0;
            this.cbAttributes.Text = "Attrbitues";
            this.cbAttributes.UseVisualStyleBackColor = true;
            // 
            // cbMatchedFields
            // 
            this.cbMatchedFields.AutoSize = true;
            this.cbMatchedFields.Location = new System.Drawing.Point(499, 59);
            this.cbMatchedFields.Name = "cbMatchedFields";
            this.cbMatchedFields.Size = new System.Drawing.Size(98, 17);
            this.cbMatchedFields.TabIndex = 0;
            this.cbMatchedFields.Text = "Matched Fields";
            this.cbMatchedFields.UseVisualStyleBackColor = true;
            // 
            // cbLinks
            // 
            this.cbLinks.AutoSize = true;
            this.cbLinks.Location = new System.Drawing.Point(417, 59);
            this.cbLinks.Name = "cbLinks";
            this.cbLinks.Size = new System.Drawing.Size(51, 17);
            this.cbLinks.TabIndex = 0;
            this.cbLinks.Text = "Links";
            this.cbLinks.UseVisualStyleBackColor = true;
            // 
            // cbItemType
            // 
            this.cbItemType.AutoSize = true;
            this.cbItemType.Location = new System.Drawing.Point(319, 59);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(73, 17);
            this.cbItemType.TabIndex = 0;
            this.cbItemType.Text = "Item Type";
            this.cbItemType.UseVisualStyleBackColor = true;
            // 
            // cbHasChildren
            // 
            this.cbHasChildren.AutoSize = true;
            this.cbHasChildren.Location = new System.Drawing.Point(216, 59);
            this.cbHasChildren.Name = "cbHasChildren";
            this.cbHasChildren.Size = new System.Drawing.Size(86, 17);
            this.cbHasChildren.TabIndex = 0;
            this.cbHasChildren.Text = "Has Children";
            this.cbHasChildren.UseVisualStyleBackColor = true;
            // 
            // cbEndTime
            // 
            this.cbEndTime.AutoSize = true;
            this.cbEndTime.Location = new System.Drawing.Point(129, 59);
            this.cbEndTime.Name = "cbEndTime";
            this.cbEndTime.Size = new System.Drawing.Size(71, 17);
            this.cbEndTime.TabIndex = 0;
            this.cbEndTime.Text = "End Time";
            this.cbEndTime.UseVisualStyleBackColor = true;
            // 
            // cbDescription
            // 
            this.cbDescription.AutoSize = true;
            this.cbDescription.Location = new System.Drawing.Point(722, 59);
            this.cbDescription.Name = "cbDescription";
            this.cbDescription.Size = new System.Drawing.Size(79, 17);
            this.cbDescription.TabIndex = 0;
            this.cbDescription.Text = "Description";
            this.cbDescription.UseVisualStyleBackColor = true;
            // 
            // cbDataPipe
            // 
            this.cbDataPipe.AutoSize = true;
            this.cbDataPipe.Location = new System.Drawing.Point(722, 36);
            this.cbDataPipe.Name = "cbDataPipe";
            this.cbDataPipe.Size = new System.Drawing.Size(73, 17);
            this.cbDataPipe.TabIndex = 0;
            this.cbDataPipe.Text = "DataType";
            this.cbDataPipe.UseVisualStyleBackColor = true;
            // 
            // cbWebID
            // 
            this.cbWebID.AutoSize = true;
            this.cbWebID.Location = new System.Drawing.Point(624, 59);
            this.cbWebID.Name = "cbWebID";
            this.cbWebID.Size = new System.Drawing.Size(60, 17);
            this.cbWebID.TabIndex = 0;
            this.cbWebID.Text = "WebID";
            this.cbWebID.UseVisualStyleBackColor = true;
            // 
            // cbUom
            // 
            this.cbUom.AutoSize = true;
            this.cbUom.Location = new System.Drawing.Point(624, 36);
            this.cbUom.Name = "cbUom";
            this.cbUom.Size = new System.Drawing.Size(48, 17);
            this.cbUom.TabIndex = 0;
            this.cbUom.Text = "Uom";
            this.cbUom.UseVisualStyleBackColor = true;
            // 
            // cbUniqueID
            // 
            this.cbUniqueID.AutoSize = true;
            this.cbUniqueID.Location = new System.Drawing.Point(499, 36);
            this.cbUniqueID.Name = "cbUniqueID";
            this.cbUniqueID.Size = new System.Drawing.Size(74, 17);
            this.cbUniqueID.TabIndex = 0;
            this.cbUniqueID.Text = "Unique ID";
            this.cbUniqueID.UseVisualStyleBackColor = true;
            // 
            // cbTemplate
            // 
            this.cbTemplate.AutoSize = true;
            this.cbTemplate.Location = new System.Drawing.Point(417, 36);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Size = new System.Drawing.Size(70, 17);
            this.cbTemplate.TabIndex = 0;
            this.cbTemplate.Text = "Template";
            this.cbTemplate.UseVisualStyleBackColor = true;
            // 
            // cbStartTime
            // 
            this.cbStartTime.AutoSize = true;
            this.cbStartTime.Location = new System.Drawing.Point(318, 36);
            this.cbStartTime.Name = "cbStartTime";
            this.cbStartTime.Size = new System.Drawing.Size(74, 17);
            this.cbStartTime.TabIndex = 0;
            this.cbStartTime.Text = "Start Time";
            this.cbStartTime.UseVisualStyleBackColor = true;
            // 
            // cbPlottable
            // 
            this.cbPlottable.AutoSize = true;
            this.cbPlottable.Location = new System.Drawing.Point(129, 36);
            this.cbPlottable.Name = "cbPlottable";
            this.cbPlottable.Size = new System.Drawing.Size(67, 17);
            this.cbPlottable.TabIndex = 0;
            this.cbPlottable.Text = "Plottable";
            this.cbPlottable.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Checked = true;
            this.cbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbName.Location = new System.Drawing.Point(216, 36);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(54, 17);
            this.cbName.TabIndex = 0;
            this.cbName.Text = "Name";
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // cbAFCateogory
            // 
            this.cbAFCateogory.AutoSize = true;
            this.cbAFCateogory.Checked = true;
            this.cbAFCateogory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAFCateogory.Location = new System.Drawing.Point(39, 36);
            this.cbAFCateogory.Name = "cbAFCateogory";
            this.cbAFCateogory.Size = new System.Drawing.Size(81, 17);
            this.cbAFCateogory.TabIndex = 0;
            this.cbAFCateogory.Text = "AFCategory";
            this.cbAFCateogory.UseVisualStyleBackColor = true;
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(603, 29);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(71, 20);
            this.nudCount.TabIndex = 5;
            this.nudCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudStart
            // 
            this.nudStart.Location = new System.Drawing.Point(697, 29);
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(71, 20);
            this.nudStart.TabIndex = 5;
            // 
            // btnViewJson
            // 
            this.btnViewJson.Location = new System.Drawing.Point(730, 615);
            this.btnViewJson.Name = "btnViewJson";
            this.btnViewJson.Size = new System.Drawing.Size(151, 23);
            this.btnViewJson.TabIndex = 6;
            this.btnViewJson.Text = "View stream data";
            this.btnViewJson.UseVisualStyleBackColor = true;
            this.btnViewJson.Click += new System.EventHandler(this.btnViewJson_Click);
            // 
            // lbQuery
            // 
            this.lbQuery.AutoSize = true;
            this.lbQuery.Location = new System.Drawing.Point(31, 10);
            this.lbQuery.Name = "lbQuery";
            this.lbQuery.Size = new System.Drawing.Size(35, 13);
            this.lbQuery.TabIndex = 7;
            this.lbQuery.Text = "Query";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Option";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(694, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Start";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(57, 182);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(805, 20);
            this.tbUrl.TabIndex = 8;
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(31, 185);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(20, 13);
            this.lbUrl.TabIndex = 9;
            this.lbUrl.Text = "Url";
            // 
            // btnCopyJson
            // 
            this.btnCopyJson.Location = new System.Drawing.Point(730, 677);
            this.btnCopyJson.Name = "btnCopyJson";
            this.btnCopyJson.Size = new System.Drawing.Size(151, 23);
            this.btnCopyJson.TabIndex = 10;
            this.btnCopyJson.Text = "Copy Json response";
            this.btnCopyJson.UseVisualStyleBackColor = true;
            this.btnCopyJson.Click += new System.EventHandler(this.btnCopyJson_Click);
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 758);
            this.Controls.Add(this.btnCopyJson);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbQuery);
            this.Controls.Add(this.btnViewJson);
            this.Controls.Add(this.nudStart);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.gbFields);
            this.Controls.Add(this.gbDataSources);
            this.Controls.Add(this.cbQueryOptions);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbQuery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinForm";
            this.Text = "PI Indexed Search App";
            this.gbFields.ResumeLayout(false);
            this.gbFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.ComboBox cbQueryOptions;
        private System.Windows.Forms.GroupBox gbDataSources;
        private System.Windows.Forms.GroupBox gbFields;
        private System.Windows.Forms.CheckBox cbAttributes;
        private System.Windows.Forms.CheckBox cbLinks;
        private System.Windows.Forms.CheckBox cbItemType;
        private System.Windows.Forms.CheckBox cbHasChildren;
        private System.Windows.Forms.CheckBox cbEndTime;
        private System.Windows.Forms.CheckBox cbDescription;
        private System.Windows.Forms.CheckBox cbDataPipe;
        private System.Windows.Forms.CheckBox cbAFCateogory;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.CheckBox cbMatchedFields;
        private System.Windows.Forms.CheckBox cbWebID;
        private System.Windows.Forms.CheckBox cbUom;
        private System.Windows.Forms.CheckBox cbUniqueID;
        private System.Windows.Forms.CheckBox cbTemplate;
        private System.Windows.Forms.CheckBox cbStartTime;
        private System.Windows.Forms.CheckBox cbPlottable;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.Button btnViewJson;
        private System.Windows.Forms.Label lbQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.Button btnCopyJson;
    }
}

