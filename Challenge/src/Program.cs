using Challenge.src.Domain.Builders;

namespace Challenge.src
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Relatórios ===");

            var report1 = new SalesReportBuilder()
                .WithTitle("Vendas Mensais")
                .WithFormat("PDF")
                .WithStartDate(new DateTime(2024, 1, 1))
                .WithEndDate(new DateTime(2024, 1, 31))
                .WithIncludeSummary(true)
                .AddColumn("Produto")
                .AddColumn("Quantidade")
                .AddColumn("Valor")
                .AddFilter("Status=Ativo")
                .WithSortBy("Valor")
                .WithGroupBy("Categoria")
                .WithIncludeTotals(true)
                .WithOrientation("Portrait")
                .WithPageSize("A4")
                .WithIncludePageNumbers(true)
                .WithCompanyLogo("logo.png")
                .WithWaterMark("Confidencial")
                .Build();

            report1.Generate();

            var report2 = new SalesReportBuilder()
                .WithTitle("Relatório Trimestral")
                .WithFormat("Excel")
                .WithStartDate(new DateTime(2024, 1, 1))
                .WithEndDate(new DateTime(2024, 3, 31))
                .AddColumn("Vendedor")
                .AddColumn("Região")
                .AddColumn("Total")
                .WithChartType("Line")
                .WithHeaderText("Teste")
                .WithGroupBy("Região")
                .Build();


            report2.Generate();

            var report3 = new SalesReportBuilder()
                .WithTitle("VendasAnuais")
                .WithFormat("PDF")
                .WithStartDate(new DateTime(2024, 1, 1))
                .WithEndDate(new DateTime(2024, 12, 31))
                .WithHeaderText("Relatório de Vendas")
                .WithFooterText("Confidencial")
                .AddColumn("Produto")
                .AddColumn("Quantidade")
                .AddColumn("Valor")
                .WithChartType("Pie")
                .WithIncludeTotals(true)
                .WithOrientation("Landscape")
                .WithPageSize("A4")
                .Build();

            report3.Generate();
        }
    }
}