using Challenge.src.Domain.Entites;

namespace Challenge.src.Domain.Builders
{
    public class SalesReportBuilder
    {
        private SalesReport _salesReport = new SalesReport();

        public SalesReportBuilder WithTitle(string title)
        {
            _salesReport.Title = title;
            return this;
        }

        public SalesReportBuilder WithFormat(string format)
        {
            _salesReport.Format = format;
            return this;
        }

        public SalesReportBuilder WithStartDate(DateTime startDate)
        {
            _salesReport.StartDate = startDate;
            return this;
        }

        public SalesReportBuilder WithEndDate(DateTime endDate)
        {
            _salesReport.EndDate = endDate;
            return this;
        }   

        public SalesReportBuilder WithHeaderText(string headerText)
        {
            _salesReport.IncludeHeader = true;
            _salesReport.HeaderText = headerText;
            return this;
        }

        public SalesReportBuilder WithFooterText(string footerText)
        {
            _salesReport.IncludeFooter = true;
            _salesReport.FooterText = footerText;
            return this;
        }

        public SalesReportBuilder WithChartType(string chartType)
        {
            _salesReport.IncludeCharts = true;
            _salesReport.ChartType = chartType;
            return this;
        }

        public SalesReportBuilder WithIncludeSummary(bool includeSummary)
        {
            _salesReport.IncludeSummary = includeSummary;
            return this;
        }

        public SalesReportBuilder AddColumn(string column)
        {
            _salesReport.Columns.Add(column);
            return this;
        }

        public SalesReportBuilder AddFilter(string filter)
        {
            _salesReport.Filters.Add(filter);
            return this;
        }
        
        public SalesReportBuilder WithSortBy(string sortBy)
        {
            _salesReport.SortBy = sortBy;
            return this;
        }

        public SalesReportBuilder WithGroupBy(string groupBy)
        {
            _salesReport.GroupBy = groupBy;
            return this;
        }

        public SalesReportBuilder WithIncludeTotals(bool includeTotals)
        {
            _salesReport.IncludeTotals = includeTotals;
            return this;
        }

        public SalesReportBuilder WithOrientation(string orientation)
        {
            _salesReport.Orientation = orientation;
            return this;
        }

        public SalesReportBuilder WithPageSize(string pageSize)
        {
            _salesReport.PageSize = pageSize;
            return this;
        }

        public SalesReportBuilder WithIncludePageNumbers(bool includePageNumbers)
        {
            _salesReport.IncludePageNumbers = includePageNumbers;
            return this;
        }

        public SalesReportBuilder WithCompanyLogo(string companyLogo)
        {
            _salesReport.CompanyLogo = companyLogo;
            return this;
        }

        public SalesReportBuilder WithWaterMark(string waterMark)
        {
            _salesReport.WaterMark = waterMark;
            return this;
        }

        public SalesReport Build()
        {
            if (string.IsNullOrWhiteSpace(_salesReport.Title)) throw new InvalidOperationException(nameof(_salesReport.Title));
            if (string.IsNullOrWhiteSpace(_salesReport.Format)) throw new InvalidOperationException(nameof(_salesReport.Format));

            return _salesReport;
        }
    }
}