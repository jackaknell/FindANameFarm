namespace FindANameFarm
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Contact { get; set; }
        public string Password { get; set; }
        
        private string _imageFile;
        private const string DefaultImage = "";

        public string ImageFile
        {
            get => _imageFile;

            set => _imageFile = value ?? DefaultImage;
        }
    }


}
