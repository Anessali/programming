/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package makeanimal;

/**
 *
 * @author liggettt
 */
public class Dog {
    String name;
    String breed;
    int age;
    
    public Dog(){
        
    }
    
    public Dog(String dogName){
        name = dogName;
    }
    
    public Dog(String dogName, String breed){
        name = dogName;
        this.breed = breed;
    }
    
    public void speak(int numOfRuffs){
        for (int i = 0; i < numOfRuffs; i++){
            System.out.println("Ruff! " + name);
        }
    }
}
