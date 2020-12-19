namespace lab_1
{
    class Car
    {
        public string brand; 
        public string nameCar;
        public long price;
        public int yearOfRelease;
        public string transmition; // КПП
        public string drive; // привод
        public Color color;
        public string carClass;

        public Car(string brand, string name, long price, int year, string transmition, string drive, Color color, string carClass)
        {
            this.brand = brand;
            nameCar = name;
            this.price = price;
            yearOfRelease = year;
            this.transmition = transmition;
            this.drive = drive;
            this.color = color;
            this.carClass = carClass;
        }
    }
}
