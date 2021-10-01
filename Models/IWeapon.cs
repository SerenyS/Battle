namespace WCTC_Battle.Models
{
    public interface IWeapon
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public string Size {get;set;}
    }
}