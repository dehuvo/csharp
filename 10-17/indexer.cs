using System;
public class Animation {
  private int total; //총 애니메이션 편수
  private string[] title; //각 볼륨당 제목
  private string distributor; //유통사
  private string date; //제작날짜
  private int price; //가격
  public Animation(int total, string distributor, string date, int price) {
    this.total = total;
    this.title = new string[total];
    this.distributor = distributor;
    this.date = date;
    this.price = price;
  }
  //이부분에서 인덱서를 정의 한다. 이전 프로그램의 setTitle, getTitle이 인덱서로 대체됨,
  //결국 this라는 Property가 인덱서인 것이다.
public string this[int index] // Animation a= new Animation(); a[0] = “심청전”;
{
    get { return title[index]; }
    set { title[index] = value; }
  }
  //제작사 정보를 읽어옴
  public string getDistributor() { return distributor; }
  //가격 정보를 읽어옴
  public int getPrice() { return price; }
  //총애니메이션의 수를 알아내는 메소드
  public int getTotal() { return total; }
}
class AniTest {
  static void Main() {
    Animation ani = new Animation(5, "한국애니", "10-27-2004", 35000);
    ani[0] = "인어공주";
    ani[1] = "신데렐라";
    ani[2] = "백설공주";
    ani[3] = "바보온달";
    ani[4] = "라이온킹";
    Console.WriteLine("배급사: {0}", ani.getDistributor());
    Console.WriteLine("가격: {0}", ani.getPrice());
    Console.WriteLine("----------------------------");
    for (int i = 0; i < ani.getTotal(); i++) {
      Console.WriteLine("Volume{0} : {1}", i, ani[i]);
    }
  }
}