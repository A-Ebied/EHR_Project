namespace EHR_MVC.Extensions
{
    public static class SD
    {
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public static string JWT = "JWTToken";

        public const string SystemManager = "SystemManager";
        public const string HealthFacilitiesAdministrator = "HealthFacilitiesAdministrator";
        public const string HealthFacilityManager = "HealthFacilityManager";
        public const string Physician = "Physician";
        public const string Nurse = "Nurse";
        public const string Technician = "Technician";
        public const string Pharmacist = "Pharmacist";
        public const string Patient = "Patient";
    }
}
