namespace ISM.Application.interfaces
{
    public  interface Ivalidation<T>where T : class
    {
        public bool Create(T objectname);
        public bool Delete(int Id);
        public bool Update(T objectname);
        public bool Getall();
        public bool Getby(int Id);
    }
}
