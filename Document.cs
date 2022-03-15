namespace VismaHomework
{
    class Document
    {
        private string docNumber;
        private int maxSum;
        private DateOnly date;
        private Rows[] rows = new Rows[] {};

        public Document(string docNumber, int maxSum)
        {
            this.docNumber = docNumber;
            this.maxSum = maxSum;
        }

        public string getDocNumber()
        {
            return this.docNumber;
        }

        public void setDocNumber(string docNumber)
        {
            this.docNumber = docNumber;
        }

        public int getMaxSum()
        {
            return this.maxSum;
        }

        public void setMaxSum(int maxSum)
        {
            this.maxSum = maxSum;
        }

        public DateOnly getDate()
        {
            return this.date;
        }

        public void setDate(DateOnly date)
        {
            this.date = date;
        }

        public Rows[] getRows()
        {
            return this.rows;
        }

        public void setRows(Rows[] rows)
        {
            this.rows = rows;
        }
    }
}    