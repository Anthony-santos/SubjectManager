namespace Api.Models{
    public class Lesson{
        public Lesson(string DayOfWeak, string StartTime, string EndTime){
            this.DayOfWeak = DayOfWeak;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
        }
        public int Id { set; get; }
        public string DayOfWeak { set; get; }
        public string StartTime { set; get; }
        public string EndTime { set; get; }
    }
}