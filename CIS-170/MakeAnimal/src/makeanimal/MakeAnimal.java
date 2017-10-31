/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package makeanimal;
import different.Dog;

/**
 *
 * @author liggettt
 */
public class MakeAnimal {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
//        String dog1Name = "fido";
//        String dog1Breed = "german shepard";
//        int dog1Age = 6;
//        
//        String dog2Name = "spot";
//        String dog2Breed = "lab";
//        int dog2Age = 3;
        
        Dog dog1 = new Dog();
        dog1.name = "Fido";
        dog1.breed = "Labrador";
        dog1.age = 6;
        dog1.speak(2);
        
        Dog dog2 = new Dog("Rawrfo");
        //dog2.name = "Rawrfo";
        dog2.breed = "Huskie";
        dog2.age = 3;
        dog2.speak(3);
        System.out.println(dog2.getSpaPrice());
        
        Dog dog3 = new Dog("Sir Borksalot", "Retriever");
        System.out.println(dog3.breed);
        System.out.println(dog2.numOfDogs);
        System.out.println(dog3.numOfDogs);
        System.out.println(Dog.numOfDogs);
        
        //create a constructor with name and breed
        
    }   
}