namespace MetroThing.Types.Validation
{
    public class ValidationResult<T>
    {
        private T _validatedValue;
        public bool IsValid;
        public string Message { get; set; }

        public T ValidatedValue
        {
            get { return _validatedValue; }
            set
            {
                IsValid = value != null;
                _validatedValue = value;
            }
        }
    }
}