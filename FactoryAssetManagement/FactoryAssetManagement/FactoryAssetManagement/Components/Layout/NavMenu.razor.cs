namespace FactoryAssetManagement.Components.Layout
{
    public partial class NavMenu
    {

        public List<NavLink> NavLinks { get; set; } = new List<NavLink>()
        {
            new() { Name = "Home", Url = "/Home", Class = "bi bi-house-door-fill-nav-menu" },
            new() { Name = "Counter", Url = "/counter", Class = "bi bi-plus-square-fill-nav-menu" },
            new() { Name = "Weather", Url = "/weather", Class = "bi bi-list-nested-nav-menu" },
            //new() { Name = "Login", Url = "/login", Class = "fa-solid fa-key pe-3 text-xl" },
        };


    }

    public class NavLink
    {
        public string Name { get; set; } = "";
        public string Url { get; set; } = "";
        public string Class { get; set; } = "";
    }
}