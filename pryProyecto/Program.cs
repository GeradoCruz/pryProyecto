namespace pryProyecto
{
    internal static class Program
    {

        static void Main()
        {

            ApplicationConfiguration.Initialize();
           
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {

                    Application.Run(new frmPrincipal());

                }
            }
           
        }
    }
}