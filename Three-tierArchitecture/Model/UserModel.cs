namespace Model
{
    /// <summary>
    /// User类对应数据库中表 UTable，一个类对应一个表
    /// </summary>
    public class User
    {
        public User() { }
        public int ID { get; set; } //ID属性，对应表中id字段
        public string Name { get; set; }//Name属性，对应表中name字段
    }
}
