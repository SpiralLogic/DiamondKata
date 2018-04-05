namespace DiamondKata
{
    public class Diamond
    {
        public static string Create(int diameter)
        {
            if (diameter < 0 || diameter % 2 == 0) return null;

            var diamond = new string('*', diameter);

            for (var numberOfSpaces = 1; numberOfSpaces <= diameter / 2; numberOfSpaces++)
            {
                var numberOfStars = diameter - numberOfSpaces * 2;
                var row = new string(' ', numberOfSpaces) + new string('*', numberOfStars);
                
                diamond = $"{row}\n{diamond}\n{row}";
            }

            return diamond;
        }
    }
}