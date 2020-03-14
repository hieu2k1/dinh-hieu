/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Lab01;

/**
 *
 * @author VŨ ĐÌNH HIẾU
 */
public class Account {
    private String id;
    private String name;
    private int balance=0;
    
    public Account (String id, String name){
        this.balance = 0;
        this.id = id;
        this.name = name;
    }
    public Account (String id,String name, int balance){
        this.balance = 0;
        this.id=id;
        this.name=name;
        this.balance=balance;
    }
    public String getID(){
        return this.id;
    }
    public String getName(){
        return this.name;     
    }
    public int getBalance(){
        return this.balance;
    }
}