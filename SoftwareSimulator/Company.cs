namespace SoftwareSimulator
{
    public abstract class Company
    {
        internal abstract List<IEmployee> GetEmployees();
        public void CreateSoftware()
        {
            List<IEmployee> employees = GetEmployees();

            foreach (IEmployee employee in employees)
            {
                employee.DoWork();
            }
        }
    }
}
