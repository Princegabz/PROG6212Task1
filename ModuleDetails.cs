using System;

namespace PROG6212Task1
{
    public class ModuleDetails
    {
        private string ModuleCode;
        private string ModuleName;
        private int iCredits;
        private int iClassHours;
        private int iWeeks;
        private string StartDate;

        public string ModuleCode1 { get => ModuleCode; set => ModuleCode = value; }
        public string ModuleName1 { get => ModuleName; set => ModuleName = value; }
        public int ICredits { get => iCredits; set => iCredits = value; }
        public int IClassHours { get => iClassHours; set => iClassHours = value; }
        public int IWeeks { get => iWeeks; set => iWeeks = value; }
        public string StartDate1 { get => StartDate; set => StartDate = value; }


        public ModuleDetails()
        {
            ModuleCode = "";
            ModuleName = "";
            iCredits = 0;
            iClassHours = 0;
            iWeeks = 0;
            StartDate = "";
        }
        public ModuleDetails(string moduleCode, string moduleName, int iCredits, int iClassHours, int iWeeks, string StartDate)
        {
            this.ModuleCode = moduleCode;
            this.ModuleName = moduleName;
            this.iCredits = iCredits;
            this.iClassHours = iClassHours;
            this.iWeeks = iWeeks;
            this.StartDate = StartDate;
        }
        public override string ToString()
        {
            return "Module Code is: " + ModuleCode + "\n" +
                   " Module Name is: " + ModuleName + "\n" +
                   " Module Credits is: " + iCredits + "\n" +
                   " Hours per week is: " + iClassHours + "\n" +
                   " Number of Weeks in the semester is: " + iWeeks + "\n" +
                   " Start Date of the semester is: " + StartDate;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return this.ModuleCode;
                }
                else if (index == 1)
                {
                    return this.ModuleName;
                }
                else if (index == 2)
                {
                    return this.iCredits;
                }
                else if (index == 3)
                {
                    return this.iClassHours;
                }
                else if (index == 4)
                {
                    return this.iWeeks;
                }
                else if (index == 5)
                {
                    return this.StartDate;
                }
               
                return null;
            }
            set
            {
                if (index == 0)
                {
                    this.ModuleCode = (string)value; //forcing the program to know that the datatype is that of a string because it recives an object and doesnt know what it is
                }
                else if (index == 1)
                {
                    this.ModuleName = (string)value;
                }
                else if (index == 2)
                {
                    this.iCredits = (int)value;
                }
                else if (index == 3)
                {
                    this.iClassHours = (int)value;
                }
                else if (index == 4)
                {
                    this.iWeeks = (int)value;
                }
                else if (index == 5)
                {
                    this.StartDate = (string)value;
                }               
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("ModuleCode"))
                {
                    return this.ModuleCode;
                }
                else if (attrName.ToLower().Equals("ModuleName"))
                {
                    return this.ModuleName;
                }
                else if (attrName.ToLower().Equals("iCredits"))
                {
                    return this.iCredits;
                }
                else if (attrName.ToLower().Equals("iClassHours"))
                {
                    return this.iClassHours;
                }
                else if (attrName.ToLower().Equals("iWeeks"))
                {
                    return this.iWeeks;
                }
                else if (attrName.ToLower().Equals("StartDate"))
                {
                    return this.StartDate;
                }
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("ModuleCode"))
                {
                    this.ModuleCode = (string)value; 
                }
                else if (attrName.ToLower().Equals("ModuleName"))
                {
                    this.ModuleName = (string)value; 
                }
                else if (attrName.ToLower().Equals("iCredits"))
                {
                    this.iCredits = (int)value;
                }
                else if (attrName.ToLower().Equals("iClassHours"))
                {
                    this.iClassHours = (int)value;
                }
                else if (attrName.ToLower().Equals("iWeeks"))
                {
                    this.iWeeks = (int)value;
                }
                else if (attrName.ToLower().Equals("StartDate"))
                {
                    this.StartDate = (string)value;
                }
            }
        }
    }
}
