namespace NDSH.Utilities.App {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      MainTabControl = new TabControl();
      CleanUpCodeTabPage = new TabPage();
      CleanUpCodeLayoutPanel = new TableLayoutPanel();
      OutputMetadataCodeRichTextBox = new RichTextBox();
      InputMetadaCodeRichTextBox = new RichTextBox();
      MetadataCleanUpCodeButton = new Button();
      XmlSerializeTabPage = new TabPage();
      XmlSerializeLayoutPanel = new TableLayoutPanel();
      SerializeGroupBox = new GroupBox();
      SerializeV2003Button = new Button();
      TestButton = new Button();
      UseEntityCheckBox = new CheckBox();
      IsIndentedCheckBox = new CheckBox();
      SerializeV2005Button = new Button();
      SerializationOutputRichTextBox = new RichTextBox();
      SerializationInputRichTextBox = new RichTextBox();
      XmlDeserializeTabPage = new TabPage();
      XmlDeserializeLayoutPanel = new TableLayoutPanel();
      groupBox1 = new GroupBox();
      DeserializeV2003Button = new Button();
      Deserialize2005Button = new Button();
      MetadataPropertyGrid = new PropertyGrid();
      DeserializationInputTextBox = new RichTextBox();
      XsdToCodeTabPage = new TabPage();
      XsdToCodeTableLayoutPanel = new TableLayoutPanel();
      OutputCodeRichTextBox = new RichTextBox();
      InputXsdRichTextBox = new RichTextBox();
      XsdToCodeGroupBox = new GroupBox();
      XsdToCodeByStringButton = new Button();
      XsdToCodeButton = new Button();
      MetadataDatabaseTabPage = new TabPage();
      TestDatabaseButton = new Button();
      MainTabControl.SuspendLayout();
      CleanUpCodeTabPage.SuspendLayout();
      CleanUpCodeLayoutPanel.SuspendLayout();
      XmlSerializeTabPage.SuspendLayout();
      XmlSerializeLayoutPanel.SuspendLayout();
      SerializeGroupBox.SuspendLayout();
      XmlDeserializeTabPage.SuspendLayout();
      XmlDeserializeLayoutPanel.SuspendLayout();
      groupBox1.SuspendLayout();
      XsdToCodeTabPage.SuspendLayout();
      XsdToCodeTableLayoutPanel.SuspendLayout();
      XsdToCodeGroupBox.SuspendLayout();
      MetadataDatabaseTabPage.SuspendLayout();
      SuspendLayout();
      // 
      // MainTabControl
      // 
      MainTabControl.Controls.Add(CleanUpCodeTabPage);
      MainTabControl.Controls.Add(XmlSerializeTabPage);
      MainTabControl.Controls.Add(XmlDeserializeTabPage);
      MainTabControl.Controls.Add(XsdToCodeTabPage);
      MainTabControl.Controls.Add(MetadataDatabaseTabPage);
      MainTabControl.Dock = DockStyle.Fill;
      MainTabControl.HotTrack = true;
      MainTabControl.Location = new Point(6, 8);
      MainTabControl.Margin = new Padding(2);
      MainTabControl.Name = "MainTabControl";
      MainTabControl.SelectedIndex = 0;
      MainTabControl.Size = new Size(1329, 882);
      MainTabControl.TabIndex = 0;
      // 
      // CleanUpCodeTabPage
      // 
      CleanUpCodeTabPage.Controls.Add(CleanUpCodeLayoutPanel);
      CleanUpCodeTabPage.Location = new Point(4, 34);
      CleanUpCodeTabPage.Margin = new Padding(2);
      CleanUpCodeTabPage.Name = "CleanUpCodeTabPage";
      CleanUpCodeTabPage.Size = new Size(1321, 844);
      CleanUpCodeTabPage.TabIndex = 0;
      CleanUpCodeTabPage.Text = "Clean Up Code";
      CleanUpCodeTabPage.UseVisualStyleBackColor = true;
      // 
      // CleanUpCodeLayoutPanel
      // 
      CleanUpCodeLayoutPanel.ColumnCount = 2;
      CleanUpCodeLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      CleanUpCodeLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
      CleanUpCodeLayoutPanel.Controls.Add(OutputMetadataCodeRichTextBox, 0, 1);
      CleanUpCodeLayoutPanel.Controls.Add(InputMetadaCodeRichTextBox, 0, 0);
      CleanUpCodeLayoutPanel.Controls.Add(MetadataCleanUpCodeButton, 1, 0);
      CleanUpCodeLayoutPanel.Dock = DockStyle.Fill;
      CleanUpCodeLayoutPanel.Location = new Point(0, 0);
      CleanUpCodeLayoutPanel.Margin = new Padding(2);
      CleanUpCodeLayoutPanel.Name = "CleanUpCodeLayoutPanel";
      CleanUpCodeLayoutPanel.Padding = new Padding(2);
      CleanUpCodeLayoutPanel.RowCount = 2;
      CleanUpCodeLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      CleanUpCodeLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      CleanUpCodeLayoutPanel.Size = new Size(1321, 844);
      CleanUpCodeLayoutPanel.TabIndex = 0;
      // 
      // OutputMetadataCodeRichTextBox
      // 
      OutputMetadataCodeRichTextBox.Dock = DockStyle.Fill;
      OutputMetadataCodeRichTextBox.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
      OutputMetadataCodeRichTextBox.Location = new Point(6, 424);
      OutputMetadataCodeRichTextBox.Margin = new Padding(4, 2, 4, 2);
      OutputMetadataCodeRichTextBox.Name = "OutputMetadataCodeRichTextBox";
      OutputMetadataCodeRichTextBox.Size = new Size(1009, 416);
      OutputMetadataCodeRichTextBox.TabIndex = 4;
      OutputMetadataCodeRichTextBox.Text = "";
      // 
      // InputMetadaCodeRichTextBox
      // 
      InputMetadaCodeRichTextBox.Dock = DockStyle.Fill;
      InputMetadaCodeRichTextBox.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
      InputMetadaCodeRichTextBox.Location = new Point(6, 4);
      InputMetadaCodeRichTextBox.Margin = new Padding(4, 2, 4, 2);
      InputMetadaCodeRichTextBox.Name = "InputMetadaCodeRichTextBox";
      InputMetadaCodeRichTextBox.Size = new Size(1009, 416);
      InputMetadaCodeRichTextBox.TabIndex = 3;
      InputMetadaCodeRichTextBox.Text = "";
      // 
      // MetadataCleanUpCodeButton
      // 
      MetadataCleanUpCodeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      MetadataCleanUpCodeButton.Location = new Point(1023, 4);
      MetadataCleanUpCodeButton.Margin = new Padding(4, 2, 4, 2);
      MetadataCleanUpCodeButton.Name = "MetadataCleanUpCodeButton";
      MetadataCleanUpCodeButton.Size = new Size(292, 40);
      MetadataCleanUpCodeButton.TabIndex = 2;
      MetadataCleanUpCodeButton.Text = "Metadata Clean Up";
      MetadataCleanUpCodeButton.UseVisualStyleBackColor = true;
      MetadataCleanUpCodeButton.Click += MetadataCleanUpCodeButton_Click;
      // 
      // XmlSerializeTabPage
      // 
      XmlSerializeTabPage.Controls.Add(XmlSerializeLayoutPanel);
      XmlSerializeTabPage.Location = new Point(4, 34);
      XmlSerializeTabPage.Margin = new Padding(2);
      XmlSerializeTabPage.Name = "XmlSerializeTabPage";
      XmlSerializeTabPage.Size = new Size(1321, 844);
      XmlSerializeTabPage.TabIndex = 1;
      XmlSerializeTabPage.Text = "Xml Serialize";
      XmlSerializeTabPage.UseVisualStyleBackColor = true;
      // 
      // XmlSerializeLayoutPanel
      // 
      XmlSerializeLayoutPanel.ColumnCount = 2;
      XmlSerializeLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      XmlSerializeLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
      XmlSerializeLayoutPanel.Controls.Add(SerializeGroupBox, 1, 0);
      XmlSerializeLayoutPanel.Controls.Add(SerializationOutputRichTextBox, 0, 0);
      XmlSerializeLayoutPanel.Controls.Add(SerializationInputRichTextBox, 0, 1);
      XmlSerializeLayoutPanel.Dock = DockStyle.Fill;
      XmlSerializeLayoutPanel.Location = new Point(0, 0);
      XmlSerializeLayoutPanel.Margin = new Padding(2);
      XmlSerializeLayoutPanel.Name = "XmlSerializeLayoutPanel";
      XmlSerializeLayoutPanel.Padding = new Padding(2);
      XmlSerializeLayoutPanel.RowCount = 2;
      XmlSerializeLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      XmlSerializeLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      XmlSerializeLayoutPanel.Size = new Size(1321, 844);
      XmlSerializeLayoutPanel.TabIndex = 2;
      // 
      // SerializeGroupBox
      // 
      SerializeGroupBox.Controls.Add(SerializeV2003Button);
      SerializeGroupBox.Controls.Add(TestButton);
      SerializeGroupBox.Controls.Add(UseEntityCheckBox);
      SerializeGroupBox.Controls.Add(IsIndentedCheckBox);
      SerializeGroupBox.Controls.Add(SerializeV2005Button);
      SerializeGroupBox.Dock = DockStyle.Fill;
      SerializeGroupBox.Location = new Point(1023, 4);
      SerializeGroupBox.Margin = new Padding(4, 2, 4, 2);
      SerializeGroupBox.Name = "SerializeGroupBox";
      SerializeGroupBox.Padding = new Padding(4, 2, 4, 2);
      SerializeGroupBox.Size = new Size(292, 416);
      SerializeGroupBox.TabIndex = 4;
      SerializeGroupBox.TabStop = false;
      SerializeGroupBox.Text = "Serialize";
      // 
      // SerializeV2003Button
      // 
      SerializeV2003Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      SerializeV2003Button.Location = new Point(8, 72);
      SerializeV2003Button.Margin = new Padding(2);
      SerializeV2003Button.Name = "SerializeV2003Button";
      SerializeV2003Button.Size = new Size(276, 40);
      SerializeV2003Button.TabIndex = 8;
      SerializeV2003Button.Text = "Serialize V2003";
      SerializeV2003Button.UseVisualStyleBackColor = true;
      SerializeV2003Button.Click += SerializeV2003Button_Click;
      // 
      // TestButton
      // 
      TestButton.Location = new Point(8, 288);
      TestButton.Margin = new Padding(2);
      TestButton.Name = "TestButton";
      TestButton.Size = new Size(276, 40);
      TestButton.TabIndex = 6;
      TestButton.Text = "Test Button";
      TestButton.UseVisualStyleBackColor = true;
      TestButton.Click += TestButton_Click;
      // 
      // UseEntityCheckBox
      // 
      UseEntityCheckBox.AutoSize = true;
      UseEntityCheckBox.Checked = true;
      UseEntityCheckBox.CheckState = CheckState.Checked;
      UseEntityCheckBox.Location = new Point(8, 358);
      UseEntityCheckBox.Margin = new Padding(4, 2, 4, 2);
      UseEntityCheckBox.Name = "UseEntityCheckBox";
      UseEntityCheckBox.Size = new Size(116, 29);
      UseEntityCheckBox.TabIndex = 5;
      UseEntityCheckBox.Text = "Use Entity";
      UseEntityCheckBox.UseVisualStyleBackColor = true;
      // 
      // IsIndentedCheckBox
      // 
      IsIndentedCheckBox.AutoSize = true;
      IsIndentedCheckBox.Checked = true;
      IsIndentedCheckBox.CheckState = CheckState.Checked;
      IsIndentedCheckBox.Location = new Point(8, 330);
      IsIndentedCheckBox.Margin = new Padding(4, 2, 4, 2);
      IsIndentedCheckBox.Name = "IsIndentedCheckBox";
      IsIndentedCheckBox.Size = new Size(109, 29);
      IsIndentedCheckBox.TabIndex = 4;
      IsIndentedCheckBox.Text = "Indented";
      IsIndentedCheckBox.UseVisualStyleBackColor = true;
      // 
      // SerializeV2005Button
      // 
      SerializeV2005Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      SerializeV2005Button.Location = new Point(8, 28);
      SerializeV2005Button.Margin = new Padding(2);
      SerializeV2005Button.Name = "SerializeV2005Button";
      SerializeV2005Button.Size = new Size(276, 40);
      SerializeV2005Button.TabIndex = 2;
      SerializeV2005Button.Text = "Serialize V2005";
      SerializeV2005Button.UseVisualStyleBackColor = true;
      SerializeV2005Button.Click += SerializeV2005Button_Click;
      // 
      // SerializationOutputRichTextBox
      // 
      SerializationOutputRichTextBox.Dock = DockStyle.Fill;
      SerializationOutputRichTextBox.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
      SerializationOutputRichTextBox.Location = new Point(6, 4);
      SerializationOutputRichTextBox.Margin = new Padding(4, 2, 4, 2);
      SerializationOutputRichTextBox.Name = "SerializationOutputRichTextBox";
      SerializationOutputRichTextBox.Size = new Size(1009, 416);
      SerializationOutputRichTextBox.TabIndex = 7;
      SerializationOutputRichTextBox.Text = "";
      // 
      // SerializationInputRichTextBox
      // 
      SerializationInputRichTextBox.Dock = DockStyle.Fill;
      SerializationInputRichTextBox.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
      SerializationInputRichTextBox.Location = new Point(6, 424);
      SerializationInputRichTextBox.Margin = new Padding(4, 2, 4, 2);
      SerializationInputRichTextBox.Name = "SerializationInputRichTextBox";
      SerializationInputRichTextBox.Size = new Size(1009, 416);
      SerializationInputRichTextBox.TabIndex = 8;
      SerializationInputRichTextBox.Text = "";
      // 
      // XmlDeserializeTabPage
      // 
      XmlDeserializeTabPage.Controls.Add(XmlDeserializeLayoutPanel);
      XmlDeserializeTabPage.Location = new Point(4, 34);
      XmlDeserializeTabPage.Margin = new Padding(2);
      XmlDeserializeTabPage.Name = "XmlDeserializeTabPage";
      XmlDeserializeTabPage.Size = new Size(1321, 844);
      XmlDeserializeTabPage.TabIndex = 2;
      XmlDeserializeTabPage.Text = "Xml Deserialize";
      XmlDeserializeTabPage.UseVisualStyleBackColor = true;
      // 
      // XmlDeserializeLayoutPanel
      // 
      XmlDeserializeLayoutPanel.ColumnCount = 3;
      XmlDeserializeLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      XmlDeserializeLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      XmlDeserializeLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 304F));
      XmlDeserializeLayoutPanel.Controls.Add(groupBox1, 2, 0);
      XmlDeserializeLayoutPanel.Controls.Add(MetadataPropertyGrid, 0, 0);
      XmlDeserializeLayoutPanel.Controls.Add(DeserializationInputTextBox, 1, 0);
      XmlDeserializeLayoutPanel.Dock = DockStyle.Fill;
      XmlDeserializeLayoutPanel.Location = new Point(0, 0);
      XmlDeserializeLayoutPanel.Margin = new Padding(2);
      XmlDeserializeLayoutPanel.Name = "XmlDeserializeLayoutPanel";
      XmlDeserializeLayoutPanel.Padding = new Padding(2);
      XmlDeserializeLayoutPanel.RowCount = 1;
      XmlDeserializeLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      XmlDeserializeLayoutPanel.Size = new Size(1321, 844);
      XmlDeserializeLayoutPanel.TabIndex = 3;
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(DeserializeV2003Button);
      groupBox1.Controls.Add(Deserialize2005Button);
      groupBox1.Dock = DockStyle.Fill;
      groupBox1.Location = new Point(1018, 4);
      groupBox1.Margin = new Padding(4, 2, 4, 2);
      groupBox1.Name = "groupBox1";
      groupBox1.Padding = new Padding(4, 2, 4, 2);
      groupBox1.Size = new Size(297, 836);
      groupBox1.TabIndex = 4;
      groupBox1.TabStop = false;
      groupBox1.Text = "Serialize";
      // 
      // DeserializeV2003Button
      // 
      DeserializeV2003Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      DeserializeV2003Button.Location = new Point(10, 72);
      DeserializeV2003Button.Margin = new Padding(2);
      DeserializeV2003Button.Name = "DeserializeV2003Button";
      DeserializeV2003Button.Size = new Size(279, 40);
      DeserializeV2003Button.TabIndex = 12;
      DeserializeV2003Button.Text = "Deserialize V2003";
      DeserializeV2003Button.UseVisualStyleBackColor = true;
      DeserializeV2003Button.Click += DeserializeV2003Button_Click;
      // 
      // Deserialize2005Button
      // 
      Deserialize2005Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      Deserialize2005Button.Location = new Point(10, 28);
      Deserialize2005Button.Margin = new Padding(2);
      Deserialize2005Button.Name = "Deserialize2005Button";
      Deserialize2005Button.Size = new Size(279, 40);
      Deserialize2005Button.TabIndex = 11;
      Deserialize2005Button.Text = "Deserialize 2005";
      Deserialize2005Button.UseVisualStyleBackColor = true;
      Deserialize2005Button.Click += Deserialize2005Button_Click;
      // 
      // MetadataPropertyGrid
      // 
      MetadataPropertyGrid.Dock = DockStyle.Fill;
      MetadataPropertyGrid.Location = new Point(4, 4);
      MetadataPropertyGrid.Margin = new Padding(2);
      MetadataPropertyGrid.Name = "MetadataPropertyGrid";
      MetadataPropertyGrid.Size = new Size(502, 836);
      MetadataPropertyGrid.TabIndex = 5;
      // 
      // DeserializationInputTextBox
      // 
      DeserializationInputTextBox.Dock = DockStyle.Fill;
      DeserializationInputTextBox.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
      DeserializationInputTextBox.Location = new Point(510, 4);
      DeserializationInputTextBox.Margin = new Padding(2);
      DeserializationInputTextBox.Name = "DeserializationInputTextBox";
      DeserializationInputTextBox.Size = new Size(502, 836);
      DeserializationInputTextBox.TabIndex = 6;
      DeserializationInputTextBox.Text = "";
      DeserializationInputTextBox.WordWrap = false;
      // 
      // XsdToCodeTabPage
      // 
      XsdToCodeTabPage.Controls.Add(XsdToCodeTableLayoutPanel);
      XsdToCodeTabPage.Location = new Point(4, 34);
      XsdToCodeTabPage.Margin = new Padding(2);
      XsdToCodeTabPage.Name = "XsdToCodeTabPage";
      XsdToCodeTabPage.Size = new Size(1321, 844);
      XsdToCodeTabPage.TabIndex = 3;
      XsdToCodeTabPage.Text = "Xsd to Code";
      XsdToCodeTabPage.UseVisualStyleBackColor = true;
      // 
      // XsdToCodeTableLayoutPanel
      // 
      XsdToCodeTableLayoutPanel.ColumnCount = 2;
      XsdToCodeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      XsdToCodeTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
      XsdToCodeTableLayoutPanel.Controls.Add(OutputCodeRichTextBox, 0, 0);
      XsdToCodeTableLayoutPanel.Controls.Add(InputXsdRichTextBox, 0, 1);
      XsdToCodeTableLayoutPanel.Controls.Add(XsdToCodeGroupBox, 1, 0);
      XsdToCodeTableLayoutPanel.Dock = DockStyle.Fill;
      XsdToCodeTableLayoutPanel.Location = new Point(0, 0);
      XsdToCodeTableLayoutPanel.Margin = new Padding(2);
      XsdToCodeTableLayoutPanel.Name = "XsdToCodeTableLayoutPanel";
      XsdToCodeTableLayoutPanel.Padding = new Padding(2);
      XsdToCodeTableLayoutPanel.RowCount = 2;
      XsdToCodeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      XsdToCodeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      XsdToCodeTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
      XsdToCodeTableLayoutPanel.Size = new Size(1321, 844);
      XsdToCodeTableLayoutPanel.TabIndex = 1;
      // 
      // OutputCodeRichTextBox
      // 
      OutputCodeRichTextBox.Dock = DockStyle.Fill;
      OutputCodeRichTextBox.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
      OutputCodeRichTextBox.Location = new Point(6, 4);
      OutputCodeRichTextBox.Margin = new Padding(4, 2, 4, 2);
      OutputCodeRichTextBox.Name = "OutputCodeRichTextBox";
      OutputCodeRichTextBox.Size = new Size(1009, 416);
      OutputCodeRichTextBox.TabIndex = 3;
      OutputCodeRichTextBox.Text = "";
      // 
      // InputXsdRichTextBox
      // 
      InputXsdRichTextBox.Dock = DockStyle.Fill;
      InputXsdRichTextBox.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
      InputXsdRichTextBox.Location = new Point(6, 424);
      InputXsdRichTextBox.Margin = new Padding(4, 2, 4, 2);
      InputXsdRichTextBox.Name = "InputXsdRichTextBox";
      InputXsdRichTextBox.Size = new Size(1009, 416);
      InputXsdRichTextBox.TabIndex = 4;
      InputXsdRichTextBox.Text = "";
      // 
      // XsdToCodeGroupBox
      // 
      XsdToCodeGroupBox.Controls.Add(XsdToCodeByStringButton);
      XsdToCodeGroupBox.Controls.Add(XsdToCodeButton);
      XsdToCodeGroupBox.Location = new Point(1023, 4);
      XsdToCodeGroupBox.Margin = new Padding(4, 2, 4, 2);
      XsdToCodeGroupBox.Name = "XsdToCodeGroupBox";
      XsdToCodeGroupBox.Padding = new Padding(4, 2, 4, 2);
      XsdToCodeGroupBox.Size = new Size(291, 408);
      XsdToCodeGroupBox.TabIndex = 6;
      XsdToCodeGroupBox.TabStop = false;
      XsdToCodeGroupBox.Text = "XSD to Code";
      // 
      // XsdToCodeByStringButton
      // 
      XsdToCodeByStringButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      XsdToCodeByStringButton.Location = new Point(9, 75);
      XsdToCodeByStringButton.Margin = new Padding(4, 2, 4, 2);
      XsdToCodeByStringButton.Name = "XsdToCodeByStringButton";
      XsdToCodeByStringButton.Size = new Size(272, 40);
      XsdToCodeByStringButton.TabIndex = 6;
      XsdToCodeByStringButton.Text = "Xsd to Code (String)";
      XsdToCodeByStringButton.UseVisualStyleBackColor = true;
      XsdToCodeByStringButton.Click += XsdToCodeByStringButton_Click;
      // 
      // XsdToCodeButton
      // 
      XsdToCodeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      XsdToCodeButton.Location = new Point(9, 28);
      XsdToCodeButton.Margin = new Padding(4, 2, 4, 2);
      XsdToCodeButton.Name = "XsdToCodeButton";
      XsdToCodeButton.Size = new Size(272, 40);
      XsdToCodeButton.TabIndex = 5;
      XsdToCodeButton.Text = "Xsd to Code";
      XsdToCodeButton.UseVisualStyleBackColor = true;
      XsdToCodeButton.Click += XsdToCodeButton_Click;
      // 
      // MetadataDatabaseTabPage
      // 
      MetadataDatabaseTabPage.Controls.Add(TestDatabaseButton);
      MetadataDatabaseTabPage.Location = new Point(4, 34);
      MetadataDatabaseTabPage.Name = "MetadataDatabaseTabPage";
      MetadataDatabaseTabPage.Padding = new Padding(3);
      MetadataDatabaseTabPage.Size = new Size(1321, 844);
      MetadataDatabaseTabPage.TabIndex = 4;
      MetadataDatabaseTabPage.Text = "Metadata Database";
      MetadataDatabaseTabPage.UseVisualStyleBackColor = true;
      // 
      // TestDatabaseButton
      // 
      TestDatabaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      TestDatabaseButton.Location = new Point(1043, 6);
      TestDatabaseButton.Name = "TestDatabaseButton";
      TestDatabaseButton.Size = new Size(272, 40);
      TestDatabaseButton.TabIndex = 0;
      TestDatabaseButton.Text = "Test Database";
      TestDatabaseButton.UseVisualStyleBackColor = true;
      TestDatabaseButton.Click += TestDatabaseButton_Click;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1341, 898);
      Controls.Add(MainTabControl);
      Margin = new Padding(2);
      Name = "MainForm";
      Padding = new Padding(6, 8, 6, 8);
      Text = "Utilities App";
      WindowState = FormWindowState.Maximized;
      Activated += MainForm_Activated;
      Load += MainForm_Load;
      MainTabControl.ResumeLayout(false);
      CleanUpCodeTabPage.ResumeLayout(false);
      CleanUpCodeLayoutPanel.ResumeLayout(false);
      XmlSerializeTabPage.ResumeLayout(false);
      XmlSerializeLayoutPanel.ResumeLayout(false);
      SerializeGroupBox.ResumeLayout(false);
      SerializeGroupBox.PerformLayout();
      XmlDeserializeTabPage.ResumeLayout(false);
      XmlDeserializeLayoutPanel.ResumeLayout(false);
      groupBox1.ResumeLayout(false);
      XsdToCodeTabPage.ResumeLayout(false);
      XsdToCodeTableLayoutPanel.ResumeLayout(false);
      XsdToCodeGroupBox.ResumeLayout(false);
      MetadataDatabaseTabPage.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private TabControl MainTabControl;
    private TabPage CleanUpCodeTabPage;
    private TabPage XmlSerializeTabPage;
    private TableLayoutPanel CleanUpCodeLayoutPanel;
    private Button MetadataCleanUpCodeButton;
    private TableLayoutPanel XmlSerializeLayoutPanel;
    private CheckBox IsIndentedCheckBox;
    private Button SerializeV2005Button;
    private GroupBox SerializeGroupBox;
    private CheckBox UseEntityCheckBox;
    private Button TestButton;
    private RichTextBox InputMetadaCodeRichTextBox;
    private RichTextBox OutputMetadataCodeRichTextBox;
    private Button SerializeV2003Button;
    private TabPage XmlDeserializeTabPage;
    private TableLayoutPanel XmlDeserializeLayoutPanel;
    private GroupBox groupBox1;
    private Button DeserializeV2003Button;
    private Button Deserialize2005Button;
    private PropertyGrid MetadataPropertyGrid;
    private RichTextBox DeserializationInputTextBox;
    private TabPage XsdToCodeTabPage;
    private TableLayoutPanel XsdToCodeTableLayoutPanel;
    private RichTextBox OutputCodeRichTextBox;
    private RichTextBox InputXsdRichTextBox;
    private RichTextBox SerializationOutputRichTextBox;
    private RichTextBox SerializationInputRichTextBox;
    private GroupBox XsdToCodeGroupBox;
    private Button XsdToCodeButton;
    private Button XsdToCodeByStringButton;
    private TabPage MetadataDatabaseTabPage;
    private Button TestDatabaseButton;
  }
}