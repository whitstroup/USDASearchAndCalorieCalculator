namespace USDASearchApp.Models
{
        public class LabelNutrients
        {
            public int fdcId { get; set; }
            public Fat fat { get; set; }
            public Carbohydrates carbohydrates { get; set; }
            public Sugars sugars { get; set; }
            public Protein protein { get; set; }
            public Calories calories { get; set; }
        }
}
