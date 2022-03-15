namespace VismaHomework
{
    class Rows
    {
        private string id;
        private int sum;

        public Rows(string id, int sum)
        {
            this.id = id;
            this.sum = sum;
        }

        public string getId()
        {
            return this.id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public int getSum()
        {
            return this.sum;
        }

        public void setSum(int sum)
        {
            this.sum = sum;
        }
    }
}