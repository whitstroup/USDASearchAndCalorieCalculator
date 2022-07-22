namespace USDASearchApp.Models
{
        public class LabelNutrients
        {
            public int fdcId { get; set; }
            public Fat? fat { get; set; } = new Fat();
            public Carbohydrates? carbohydrates { get; set; } = new Carbohydrates();
            public Sugars? sugars { get; set; } = new Sugars();
            public Protein? protein { get; set; } = new Protein();
            public Calories? calories { get; set; } = new Calories();
        }
}
