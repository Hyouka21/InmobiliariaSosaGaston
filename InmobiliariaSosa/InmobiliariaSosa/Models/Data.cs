using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class Data
    {   
        
    protected readonly IConfiguration configuration;
    protected readonly string conectionString;
    public Data(IConfiguration configuration)
    {
        this.configuration = configuration;
        this.conectionString = configuration["ConnectionStrings:DefaultConnection"];
    }
}
}
