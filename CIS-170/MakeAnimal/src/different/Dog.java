/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package different;

/**
 *
 * @author liggettt
 */
public class Dog {
    public String name;
    public int age;
    public String breed;
    
    public static int numOfDogs;
    private double priceToBathe;
    
    public double setSpaPrice(int weight){
        if (weight < 50) {
            priceToBathe *= 2;
        }
        return priceToBathe;
    }
    
    public double getSpaPrice(){
        return priceToBathe;
    }
    
    public Dog(){
        addDogs();
    }
    
    public Dog(String dogName){
        name = dogName;
        addDogs();
    }
    
    public Dog(String dogName, String breed){
        name = dogName;
        this.breed = breed;
        addDogs();
    }
    
    public void addDogs(){
        numOfDogs++;
        priceToBathe = 25;
    }
    
    public void speak(int numOfRuffs){
        for (int i = 0; i < numOfRuffs; i++){
            System.out.println("Ruff! " + name);
        }
    }
}
