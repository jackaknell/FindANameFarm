namespace FindANameFarm
{
   /// <summary>
   /// Ian 25/10/2018
   /// staff class defines a staff member
   /// </summary>
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
        public const string DefaultImage = "defaultImage.png";

        //public string ImageFile
        //{
        //    get => _imageFile;

        //    set => _imageFile = value ?? DefaultImage;
        //}

        public string ImageFile
        {
            get { return _imageFile; }
            set
            {
                if (null == value)
                {
                    _imageFile = DefaultImage;
                }
                else
                {
                    _imageFile = value;
                }
            }
        }
    }


}
