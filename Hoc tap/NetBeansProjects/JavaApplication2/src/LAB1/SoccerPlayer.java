/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LAB1;

/**
 *
 * @author VŨ ĐÌNH HIẾU
 */
public class SoccerPlayer {
    private final String name = "abc";
    private final int number = 23;
    private final String xlocation = "10";
    private final String ylocation = "20";

    public SoccerPlayer(){
        System.out.println("cầu thủ" + name + "số áo:" + number +"idol" + ylocation );
    }
    
    
    public void run(){  System.out.println("cầu thủ" + name);}
    public void jump(){  System.out.println("số áo:" + number);}
    public void kickBall(){  System.out.println("idol" + ylocation );}

}
