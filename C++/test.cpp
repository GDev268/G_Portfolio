#include <iostream>
#include <string>

int main(){
	
    std::string name;
    std::string placeholder;

    std::cout << "Enter your name: ";
    std::getline(std::cin, name);

    if(name.length() > 12){

        std::cout << "Your name can't have more than 12 characters" << '\n';

    }
    else if(name.length() < 12 && name.length() > 0){
 
        std::cout << "Welcome " << name << "!" << '\n';
    }
    else if(name.empty()){

        std::cout << "You didn't put your name!" << '\n';
    }

    placeholder = name;
    name.clear();

    std::cout << "Welcome" << name << '\n';

    name.append(placeholder);
    name.append("@gmail.com");

    std::cout << "Your email is: " << name << '\n';

    std::cout << "Your first character is: " << name.at(0) << '\n';

    name = placeholder;
    name.insert(0, "@");

    std::cout << "Your twitter user is: " << name << '\n';

    name = placeholder;
    placeholder = name.at(0);

    std::cout << "The position of the first letter of your name is in: " << name.find(placeholder) << '\n';
    std::cout << "Your name without the first three letters is: " << name.erase(0, 3) << '\n';


    return 0;
}

