﻿using System.Collections.Generic;

namespace USDASearchApp.Models
{
    public class Food
    {
      
            public int fdcId { get; set; }

            public string description { get; set; }

            public string brandOwner { get; set; }

            public string additionalDescriptions { get; set; }

            public List<FoodNutrient> foodNutrients { get; set; }
        
    }
}
