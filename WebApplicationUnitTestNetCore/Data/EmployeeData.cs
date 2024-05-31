namespace WebApplicationUnitTestNetCore.Data
{
    public static class EmployeeData
    {

        public static List<employee> GetEmployee()
        {
            return new() {
                 new(){ Id= 1, Name="Employe_1"},
                 new(){ Id= 2, Name="Employe_2"},
                 new(){ Id= 3, Name="Employe_3"},
                 new(){ Id= 4, Name="Employe_4"},
                 new(){ Id= 5, Name="Employe_5"},
                 new(){ Id= 6, Name="Employe_6"},
            };
        }

    }
}
