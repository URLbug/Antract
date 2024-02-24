namespace App.components.database
{
    public class Config
    {

        private Dictionary<string, string> _config = new Dictionary<string, string>()
        {
            ["database"] = "b1yx7coxtshszgkwtafm",
            ["host"] = "b1yx7coxtshszgkwtafm-postgresql.services.clever-cloud.com",
            ["username"] = "uoow5azvg2ckq2hhmzns",
            ["password"] = "M3GiNtSoNaFFoPedTA1YmnulbU7cdz",
            ["port"] = "50013",
        };

        public string get_SetUp()
        {
            return $"Server={_config["host"]};Port={_config["port"]};User Id={_config["username"]};Password={_config["password"]};Database={_config["database"]};"; ;
        }
    }
}
