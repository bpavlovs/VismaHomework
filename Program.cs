namespace VismaHomework
{
    class Program
    {
        private int excessRowSum;
        private int excessAmount;
        Random random = new Random();

        static void Main(string[] args)
        {
            Program program = new Program();
            Document document = new Document("#2022", 10);
            
            program.FillDocument(document);
            program.GetDocumentDetails(document);
        }

        private void FillDocument(Document document)
        {
            GetCurrentMonday(document);
            AddRowsToDocument(document);
        }

        private void GetDocumentDetails(Document document)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Document Details:");
            Console.WriteLine("Date: " + document.getDate().ToString("dd/MM/yyyy"));
            Console.WriteLine("Number: " + document.getDocNumber());
            Console.WriteLine("Maximal Sum: " + document.getMaxSum() + "\n");
            Console.WriteLine("Document Contens:");
            PrintRowsContent(document);
            
            Console.WriteLine("Total Row Count: " + document.getRows().Length);
            Console.Write("Total Sum: ");
            PrintTotalSum(document);

            Console.WriteLine("Skipped Row Sum: " + excessRowSum);
            Console.WriteLine("Max Sum Excess: " + excessAmount);
            Console.WriteLine("----------------------------------------------------");
        }
        
        private void AddRowsToDocument(Document document)
        {
            int maxSum = document.getMaxSum();
            Rows[] rows = document.getRows();
            int totalSum = 0;

            for (int i = 0; i <= rows.Length; i++)
            {
                Array.Resize(ref rows, rows.Length + 1);
                rows[i] = new Rows(i.ToString(), random.Next(0, (maxSum/3) + 1));
                totalSum = totalSum + rows[i].getSum();

                if(totalSum > maxSum)
                {
                    excessRowSum = rows[rows.Length - 1].getSum();
                    excessAmount = totalSum - maxSum;
                    Array.Resize(ref rows, rows.Length - 1);

                    break;
                }
            }
            document.setRows(rows);
        }

        private void PrintRowsContent(Document document)
        {
            foreach(Rows row in document.getRows())
            {
                Console.WriteLine("ID: " + row.getId() + " || " + "Sum: " + row.getSum());
            }
            Console.WriteLine("");
        }

        private void PrintTotalSum(Document document)
        {
            int totalSum = 0;

            foreach(Rows row in document.getRows())
            {
                totalSum = totalSum + row.getSum();
            }
            Console.WriteLine(totalSum);
        }

        private void GetCurrentMonday(Document document)
        {
            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            document.setDate(date.AddDays(DayOfWeek.Monday - date.DayOfWeek));
        }
    }
}