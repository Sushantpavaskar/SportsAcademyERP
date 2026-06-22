namespace SportsAcademyERP.Model.Constants
{
    public static class AppConstants
    {
        // JWT Settings
        public const string JwtKey = "SportsAcademyERP@2024SecretKeyForJWT12345";
        public const int JwtExpirationMinutes = 480; // 8 hours
        public const string JwtIssuer = "SportsAcademyERP";
        public const string JwtAudience = "SportsAcademyERPUsers";

        // App Settings
        public const string AppName = "Sports Academy ERP";
        public const string AppVersion = "1.0.0";
        public const string DefaultPassword = "Welcome@123";
        public const int PasswordMinLength = 8;

        // Database
        public const int DefaultPageSize = 10;
        public const int MaxPageSize = 100;

        // Session Keys
        public const string SessionKeyUserId = "UserId";
        public const string SessionKeyUserName = "UserName";
        public const string SessionKeyUserRole = "UserRole";
        public const string SessionKeyAcademyId = "AcademyId";
        public const string SessionKeyAcademyName = "AcademyName";
        public const string SessionKeySportId = "SportId";
        public const string SessionKeySportName = "SportName";

        // Messages
        public const string SuccessMessage = "Operation completed successfully.";
        public const string ErrorMessage = "An error occurred. Please try again.";
        public const string ValidationErrorMessage = "Please check the form for errors.";
        public const string UnauthorizedMessage = "You are not authorized to perform this action.";
        public const string NotFoundMessage = "Record not found.";

        // File Upload
        public const int MaxFileSize = 5242880; // 5MB
        public const string AllowedFileExtensions = ".jpg,.jpeg,.png,.pdf,.doc,.docx,.xls,.xlsx";
        public const string UploadDirectory = "~/Uploads/";

        // Regex Patterns
        public const string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        public const string PhonePattern = @"^[0-9]{10}$";
        public const string PincodePattern = @"^[0-9]{6}$";
    }
}
