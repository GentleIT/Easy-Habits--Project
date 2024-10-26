namespace ViewControl
{
    class Viewer 
    {
        public void Menu()
        {
            System.Console.WriteLine("Меню");
            System.Console.WriteLine("[1] Открыть трекер привычек");
            System.Console.WriteLine("[2] Добавить новую привычку");
            System.Console.WriteLine("[3] Изменить одну из привычек");
        }

        public void DataQuest()
        {
            System.Console.WriteLine($"Сегодня {здесь должна была быть переменная с датой}");
            System.Console.WriteLine("Если сегодня не это число, введите следующее.");
        }
    }
}