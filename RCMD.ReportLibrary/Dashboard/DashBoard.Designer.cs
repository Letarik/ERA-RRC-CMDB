namespace Telerik.Reporting.Examples.CSharp
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    partial class Dashboard
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.GeoLocationMapGroup geoLocationMapGroup1 = new Telerik.Reporting.GeoLocationMapGroup();
            Telerik.Reporting.MapLegend mapLegend1 = new Telerik.Reporting.MapLegend();
            Telerik.Reporting.MercatorProjection mercatorProjection1 = new Telerik.Reporting.MercatorProjection();
            Telerik.Reporting.GenericTileProvider genericTileProvider1 = new Telerik.Reporting.GenericTileProvider();
            Telerik.Reporting.MapTitle mapTitle1 = new Telerik.Reporting.MapTitle();
            Telerik.Reporting.MapGroup mapGroup1 = new Telerik.Reporting.MapGroup();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule6 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector1 = new Telerik.Reporting.Drawing.DescendantSelector();
            Telerik.Reporting.Drawing.StyleRule styleRule7 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.DescendantSelector descendantSelector2 = new Telerik.Reporting.Drawing.DescendantSelector();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.TestResultSummeryReport = new Telerik.Reporting.SqlDataSource();
            this.detail = new Telerik.Reporting.DetailSection();
            this.panel2 = new Telerik.Reporting.Panel();
            this.panel3 = new Telerik.Reporting.Panel();
            this.table1 = new Telerik.Reporting.Table();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.textBox14 = new Telerik.Reporting.TextBox();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.quarrymap = new Telerik.Reporting.Map();
            this.pointMapSeries1 = new Telerik.Reporting.PointMapSeries();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.reportHeaderSection1 = new Telerik.Reporting.ReportHeaderSection();
            this.panel5 = new Telerik.Reporting.Panel();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.shape5 = new Telerik.Reporting.Shape();
            this.textBox6 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // textBox4
            // 
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox4.StyleName = "Corporate.TableHeader";
            this.textBox4.Value = "Location_ID";
            // 
            // textBox8
            // 
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox8.StyleName = "Corporate.TableHeader";
            this.textBox8.Value = "Chanage";
            // 
            // textBox9
            // 
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox9.StyleName = "Corporate.TableHeader";
            this.textBox9.Value = "Latitude";
            // 
            // textBox10
            // 
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox10.StyleName = "Corporate.TableHeader";
            this.textBox10.Value = "Longtiude";
            // 
            // TestResultSummeryReport
            // 
            this.TestResultSummeryReport.ConnectionString = "RCMD.ReportLibrary.Properties.Settings.NRCMDBEntities";
            this.TestResultSummeryReport.Name = "TestResultSummeryReport";
            this.TestResultSummeryReport.SelectCommand = "SELECT DISTINCT Location_ID, Quarry_Area, Chanage, Latitude, Longtiude, LL, PI, S" +
    "C\r\nFROM            Summary_Report\r\nORDER BY Location_ID";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(14.260041236877441D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel2});
            this.detail.Name = "detail";
            this.detail.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(5D);
            // 
            // panel2
            // 
            this.panel2.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel3,
            this.textBox3,
            this.quarrymap,
            this.textBox7});
            this.panel2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0053583779372274876D), Telerik.Reporting.Drawing.Unit.Inch(7.8678131103515625E-05D));
            this.panel2.Name = "panel2";
            this.panel2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(23.394643783569336D), Telerik.Reporting.Drawing.Unit.Inch(14.259963035583496D));
            // 
            // panel3
            // 
            this.panel3.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.table1});
            this.panel3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0098425550386309624D), Telerik.Reporting.Drawing.Unit.Inch(0.39988192915916443D));
            this.panel3.Name = "panel3";
            this.panel3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1901576519012451D), Telerik.Reporting.Drawing.Unit.Inch(2.0197243690490723D));
            // 
            // table1
            // 
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(20D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(20D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(20D)));
            this.table1.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Mm(20D)));
            this.table1.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(5D)));
            this.table1.Body.SetCellContent(0, 0, this.textBox13);
            this.table1.Body.SetCellContent(0, 1, this.textBox14);
            this.table1.Body.SetCellContent(0, 2, this.textBox15);
            this.table1.Body.SetCellContent(0, 3, this.textBox16);
            tableGroup1.Name = "location_ID";
            tableGroup1.ReportItem = this.textBox4;
            tableGroup2.Name = "chanage";
            tableGroup2.ReportItem = this.textBox8;
            tableGroup3.Name = "latitude";
            tableGroup3.ReportItem = this.textBox9;
            tableGroup4.Name = "longtiude";
            tableGroup4.ReportItem = this.textBox10;
            this.table1.ColumnGroups.Add(tableGroup1);
            this.table1.ColumnGroups.Add(tableGroup2);
            this.table1.ColumnGroups.Add(tableGroup3);
            this.table1.ColumnGroups.Add(tableGroup4);
            this.table1.DataSource = this.TestResultSummeryReport;
            this.table1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox13,
            this.textBox14,
            this.textBox15,
            this.textBox16,
            this.textBox4,
            this.textBox8,
            this.textBox9,
            this.textBox10});
            this.table1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0.00099921226501464844D), Telerik.Reporting.Drawing.Unit.Mm(0.0010012307902798057D));
            this.table1.Name = "table1";
            tableGroup5.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup5.Name = "detail";
            this.table1.RowGroups.Add(tableGroup5);
            this.table1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(80D), Telerik.Reporting.Drawing.Unit.Mm(10D));
            this.table1.StyleName = "Corporate.TableNormal";
            // 
            // textBox13
            // 
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox13.StyleName = "Corporate.TableBody";
            this.textBox13.Value = "= Fields.Location_ID";
            // 
            // textBox14
            // 
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox14.StyleName = "Corporate.TableBody";
            this.textBox14.Value = "= Fields.Chanage";
            // 
            // textBox15
            // 
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox15.StyleName = "Corporate.TableBody";
            this.textBox15.Value = "= Fields.Latitude";
            // 
            // textBox16
            // 
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.textBox16.StyleName = "Corporate.TableBody";
            this.textBox16.Value = "= Fields.Longtiude";
            // 
            // textBox3
            // 
            this.textBox3.Anchoring = ((Telerik.Reporting.AnchoringStyles)((Telerik.Reporting.AnchoringStyles.Left | Telerik.Reporting.AnchoringStyles.Right)));
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(23.394643783569336D), Telerik.Reporting.Drawing.Unit.Inch(0.36000001430511475D));
            this.textBox3.Style.BorderColor.Bottom = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(137)))), ((int)(((byte)(104)))));
            this.textBox3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(57)))), ((int)(((byte)(27)))));
            this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16D);
            this.textBox3.TocText = "Top 5 Performing Agents";
            this.textBox3.Value = "Test Result Summery Report";
            // 
            // quarrymap
            // 
            this.quarrymap.ColorPalette = null;
            this.quarrymap.DataSource = this.TestResultSummeryReport;
            geoLocationMapGroup1.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.Quarry_Area"));
            geoLocationMapGroup1.Name = "quarry_AreaGroup";
            geoLocationMapGroup1.Sortings.Add(new Telerik.Reporting.Sorting("= Fields.Quarry_Area", Telerik.Reporting.SortDirection.Asc));
            this.quarrymap.GeoLocationGroups.Add(geoLocationMapGroup1);
            mapLegend1.Style.LineColor = System.Drawing.Color.LightGray;
            mapLegend1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.quarrymap.Legends.Add(mapLegend1);
            this.quarrymap.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(83.68389892578125D), Telerik.Reporting.Drawing.Unit.Mm(10.157000541687012D));
            this.quarrymap.Meridians.Style.LineColor = System.Drawing.Color.LightGray;
            this.quarrymap.Name = "quarrymap";
            this.quarrymap.Parallels.Style.LineColor = System.Drawing.Color.LightGray;
            this.quarrymap.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray;
            this.quarrymap.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            this.quarrymap.Projection = mercatorProjection1;
            this.quarrymap.ScaleLegend.ItemStyle.BorderColor.Default = System.Drawing.Color.White;
            this.quarrymap.ScaleLegend.ItemStyle.LineColor = System.Drawing.Color.DodgerBlue;
            this.quarrymap.ScaleLegend.ItemStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(2D);
            this.quarrymap.ScaleLegend.ItemStyle.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.quarrymap.ScaleLegend.ItemStyle.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(5D);
            this.quarrymap.ScaleLegend.ItemStyle.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.quarrymap.ScaleLegend.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
            this.quarrymap.Series.Add(this.pointMapSeries1);
            this.quarrymap.SeriesGroups.Add(mapGroup1);
            this.quarrymap.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(490.08389282226562D), Telerik.Reporting.Drawing.Unit.Mm(335.780029296875D));
            this.quarrymap.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.quarrymap.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.quarrymap.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            this.quarrymap.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10D);
            genericTileProvider1.Attribution = "© OpenStreetMap contributors";
            genericTileProvider1.LogoUrl = "http://wiki.openstreetmap.org/w/images/thumb/7/79/Public-images-osm_logo.svg/32px" +
    "-Public-images-osm_logo.svg.png";
            genericTileProvider1.UrlSubdomains.Add("a");
            genericTileProvider1.UrlSubdomains.Add("b");
            genericTileProvider1.UrlSubdomains.Add("c");
            genericTileProvider1.UrlTemplate = "http://{subdomain}.tile.openstreetmap.org/{zoom}/{X}/{Y}.png";
            this.quarrymap.TileProvider = genericTileProvider1;
            mapTitle1.Style.LineColor = System.Drawing.Color.LightGray;
            mapTitle1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0D);
            mapTitle1.Text = "Quarry Area";
            this.quarrymap.Titles.Add(mapTitle1);
            // 
            // pointMapSeries1
            // 
            this.pointMapSeries1.DataPointLabel = "= Avg(Fields.Location_ID)";
            this.pointMapSeries1.DataPointLabelStyle.Visible = false;
            this.pointMapSeries1.DataPointStyle.Visible = true;
            this.pointMapSeries1.GeoLocationGroup = geoLocationMapGroup1;
            this.pointMapSeries1.Latitude = "= (Fields.Latitude)";
            this.pointMapSeries1.LegendItem.Value = "Series 1";
            this.pointMapSeries1.Longitude = "= (Fields.Longtiude)";
            this.pointMapSeries1.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Mm(20D);
            this.pointMapSeries1.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Mm(10D);
            this.pointMapSeries1.MarkerType = Telerik.Reporting.DataPointMarkerType.Circle;
            this.pointMapSeries1.Name = "pointMapSeries1";
            mapGroup1.Name = "seriesGroup";
            this.pointMapSeries1.SeriesGroup = mapGroup1;
            this.pointMapSeries1.Size = "= Avg(Fields.Location_ID)";
            this.pointMapSeries1.ToolTip.Text = "= Avg(Fields.Location_ID)";
            this.pointMapSeries1.ToolTip.Title = "Lattitude";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(13.899962425231934D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(22.564643859863281D), Telerik.Reporting.Drawing.Unit.Inch(0.36000001430511475D));
            this.textBox7.Style.BorderColor.Bottom = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(137)))), ((int)(((byte)(104)))));
            this.textBox7.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.textBox7.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(57)))), ((int)(((byte)(27)))));
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16D);
            this.textBox7.TocText = "Top 5 Performing Stores";
            this.textBox7.Value = "Ethiopian Roads Authority ";
            // 
            // textBox5
            // 
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.4895833432674408D), Telerik.Reporting.Drawing.Unit.Inch(0.17708373069763184D));
            // 
            // reportHeaderSection1
            // 
            this.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.70003944635391235D);
            this.reportHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panel5});
            this.reportHeaderSection1.Name = "reportHeaderSection1";
            this.reportHeaderSection1.Style.Visible = true;
            // 
            // panel5
            // 
            this.panel5.Anchoring = ((Telerik.Reporting.AnchoringStyles)((Telerik.Reporting.AnchoringStyles.Left | Telerik.Reporting.AnchoringStyles.Right)));
            this.panel5.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.shape5,
            this.textBox6});
            this.panel5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0026791889686137438D), Telerik.Reporting.Drawing.Unit.Mm(0.0010012307902798057D));
            this.panel5.Name = "panel5";
            this.panel5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(23.397283554077148D), Telerik.Reporting.Drawing.Unit.Mm(17.780000686645508D));
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0026791889686137438D), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.2124595642089844D), Telerik.Reporting.Drawing.Unit.Inch(0.59992140531539917D));
            this.textBox1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(34D);
            this.textBox1.StyleName = "Header";
            this.textBox1.Value = "Quarterly Sales";
            // 
            // shape5
            // 
            this.shape5.Anchoring = ((Telerik.Reporting.AnchoringStyles)((Telerik.Reporting.AnchoringStyles.Left | Telerik.Reporting.AnchoringStyles.Right)));
            this.shape5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0026791889686137438D), Telerik.Reporting.Drawing.Unit.Inch(0.60003942251205444D));
            this.shape5.Name = "shape5";
            this.shape5.ShapeType = new Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW);
            this.shape5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(23.39000129699707D), Telerik.Reporting.Drawing.Unit.Point(3.75D));
            this.shape5.Stretch = true;
            this.shape5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.shape5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.shape5.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(3D);
            this.shape5.Style.Color = System.Drawing.Color.Transparent;
            // 
            // textBox6
            // 
            this.textBox6.Anchoring = Telerik.Reporting.AnchoringStyles.Right;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(21.247323989868164D), Telerik.Reporting.Drawing.Unit.Inch(0.22485215961933136D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1199996471405029D), Telerik.Reporting.Drawing.Unit.Inch(0.22011041641235352D));
            this.textBox6.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(47)))), ((int)(((byte)(11)))));
            this.textBox6.Style.Font.Name = "Segoe UI";
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox6.Value = "[INTERNAL PURPOSES ONLY]";
            // 
            // Dashboard
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail,
            this.reportHeaderSection1});
            this.Name = "Dashboard";
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Header")});
            styleRule2.Style.Font.Bold = true;
            styleRule2.Style.Font.Name = "Segoe UI Light";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(25D);
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextBox))});
            styleRule3.Style.Font.Name = "Segoe UI Light";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule3.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(21D);
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("legend")});
            styleRule4.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            styleRule4.Style.Font.Name = "Segoe UI Light";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.Table), "Corporate.TableNormal")});
            styleRule5.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule5.Style.Color = System.Drawing.Color.Black;
            styleRule5.Style.Font.Name = "Tahoma";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Corporate.TableBody")});
            styleRule6.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector1});
            styleRule6.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule6.Style.Font.Name = "Tahoma";
            styleRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            descendantSelector2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.Table)),
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.ReportItem), "Corporate.TableHeader")});
            styleRule7.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            descendantSelector2});
            styleRule7.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule7.Style.BorderColor.Default = System.Drawing.Color.Black;
            styleRule7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            styleRule7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1D);
            styleRule7.Style.Color = System.Drawing.Color.White;
            styleRule7.Style.Font.Name = "Tahoma";
            styleRule7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5,
            styleRule6,
            styleRule7});
            this.TocText = "Dashboard";
            this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Mm;
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(23.400001525878906D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox textBox5;
        private ReportHeaderSection reportHeaderSection1;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox6;
        private Shape shape5;
        private Reporting.Panel panel5;
        private SqlDataSource TestResultSummeryReport;
        private Reporting.Panel panel2;
        private Reporting.Panel panel3;
        private Reporting.TextBox textBox3;
        private Reporting.TextBox textBox7;
        private Table table1;
        private Reporting.TextBox textBox13;
        private Reporting.TextBox textBox14;
        private Reporting.TextBox textBox15;
        private Reporting.TextBox textBox16;
        private Reporting.TextBox textBox4;
        private Reporting.TextBox textBox8;
        private Reporting.TextBox textBox9;
        private Reporting.TextBox textBox10;
        private Map quarrymap;
        private PointMapSeries pointMapSeries1;
    }
}