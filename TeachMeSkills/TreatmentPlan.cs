﻿namespace TeachMeSkills
{
    public class TreatmentPlan
    {
        public string Name { get; set; }
        public int Code {  get; set; }

        public TreatmentPlan(string name, int code)
        {
            this.Name = name;
            this.Code = code;
        }
    }
}
