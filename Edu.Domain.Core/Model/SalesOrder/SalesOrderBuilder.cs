namespace Edu.Domain.Core.Model.SalesOrder
{
    public class SalesOrderBuilder
    {
        public SalesOrderBuilder()
        {
        }

        public SalesOrder Result
        {
            get
            {
                // Check properties on builder
                return new SalesOrder();
            }
        }
    }
}
