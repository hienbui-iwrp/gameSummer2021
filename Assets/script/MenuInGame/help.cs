using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class help : MonoBehaviour
{
    public GameObject HelpMenu;
    public Text menu1;
    public Text menu2;
    public Text menu3;
    //---
    public GameObject Law;
    public Text law0;
    public Text law1;
    public Text law2;
    public Text law3;
    public Text law4;
    public Text mission0;
    public Text mission1;
    public Text mission2;
    public Text mission3;
    public Text note0;
    public Text note1;
    //----
    public GameObject PlayInGame;
    public Text button0;
    public Text button1;
    public Text button2;
    public Text button3;
    public Text button4;
    public Text GameInfo0;
    public Text GameInfo1;
    public Text GameInfo2;
    public Text GameInfo3;
    public Text GameInfo4;
    public Text GameInfo5;
    public GameObject back;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        //menu chính
        HelpMenu.SetActive(true);
        menu1.text = "Luật chơi";
        menu2.text = "Cách thao tác";
        menu3.text = "Trở về";
        //Luật chơi
        Law.SetActive(false);
        law0.text = "Luật chơi:";
        law1.text = "- Dơi sẽ xuất hiện từ các cửa hang";
        law2.text = "- Người dân sẽ nhiễm bệnh khi bị dơi cắn.";
        law3.text = "- Người bị nhiệm bệnh có thể lấy cho người khác nếu ở đủ gần.";
        law4.text = "- Người bệnh sẽ mất máu theo thời gian và chết khi hết máu.";
        mission0.text = "Nhiệm vụ:";
        mission1.text = "- Tìm vaccine và tiến hành tiêm cho người dân, vaccine có thể tìm thấy từ một vài địa diểm bất kì hoặc có thể rơi ra khi giết dơi. Bạn có thể nhặt đá để giết dơi.";
        mission2.text = "- Vaccine chỉ có tác dụng đối với người không bị bệnh. Khi bị bệnh phải tiến hành chữa trị trước.";
        mission3.text = "Bạn sẽ thành công khi toàn dân đều có vaccine. Ngược lại, thất bại khi hơn 50% số dân bị chết hoặc dơi xâm nhập vào khu cách ly để nhiễm bệnh. Do đó phải hoàn thành càng nhanh càng tốt";
        note0.text = "Lưu ý:";
        note1.text = "Sẽ có thông báo xuất hiện khi dơi ở gần khu cách ly. Đá có thể gây sát thương lên người dân nếu bị trúng.";
        // How to play
        PlayInGame.SetActive(false);
        button0.text = "Các phím sử dụng:";
        button1.text = "- Di chuyển:";
        button2.text = "- Nhặt đá       , Vaccin       :";
        button3.text = "- Sử dụng vaccine, đưa người đi cách ly:";
        button4.text = "- Ném đá:";
        GameInfo0.text = "Các thông số:";
        GameInfo1.text = ": Số lượng người dân sống sót";
        GameInfo2.text = ": Số lượng người nhiễm bệnh";
        GameInfo3.text = ": Số lượng người đã được sử dụng Vaccine";
        GameInfo4.text = ": Số lượng đá có trong túi";
        GameInfo5.text = ": Số lượng Vaccine trong túi";
        // back button
        back.SetActive(false);
    }
    public void goLaw()
    {
        HelpMenu.SetActive(false);
        Law.SetActive(true);
        PlayInGame.SetActive(false);
        back.SetActive(true);

    }
    public void goHowToPlay()
    {
        HelpMenu.SetActive(false);
        Law.SetActive(false);
        PlayInGame.SetActive(true);
        back.SetActive(true);

    }
    public void goBack()
    {
        Law.SetActive(false);
        PlayInGame.SetActive(false);
        HelpMenu.SetActive(true);
        back.SetActive(false);
    }

}
