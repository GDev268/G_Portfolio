#include <iostream>
#include <sys/types.h>
#include <unistd.h>
#include <sys/socket.h>
#include <netdb.h>
#include <arpa/inet.h>
#include <string>
#include <string.h>

int main(int argc, char const *argv[])
{
    // Create a socket
    int listening = socket(AF_INET, SOCK_STREAM, 0);
    std::cout << listening << std::endl;
    if (listening == -1)
    {
        std::cerr << "ERROR: FAILED TO CREATE A SOCKET";
        return -1;
    }

    sockaddr_in hint;
    hint.sin_family = AF_INET;
    hint.sin_port = htons(54000);
    std::cout << inet_pton(AF_INET, "0.0.0.0", &hint.sin_addr) << std::endl;
    inet_pton(AF_INET, "0.0.0.0", &hint.sin_addr);

    // Bind the socket to a IP / port
    if (bind(AF_INET, (sockaddr *)&hint, sizeof(hint)) == -1)
    {
        std::cerr << "ERROR: CAN'T BIND TO IP/PORT" << std::endl;

        return -2;
    }

    // Mark the socket for listening in
    if (listen(listening, SOMAXCONN) == -1)
    {
        std::cerr << "ERROR: CAN'T LISTEN!" << std::endl;

        return -3;
    }

    // Accept the call
    sockaddr_in client;
    socklen_t clientSize;
    char host(NI_MAXHOST);
    char svc(NI_MAXSERV);

    int clientSocket = accept(listening, (sockaddr *)&client, &clientSize);

    if (clientSocket == -1)
    {
        std::cerr << "ERROR: PROBLEM WITH CLIENT CONNECTION!";

        return -4;
    }

    // Close the listening socket
    close(listening);
    memset(&host, 0, NI_MAXHOST);
    memset(&svc, 0, NI_MAXSERV);

    int result = getnameinfo((sockaddr *)&client, sizeof(client), &host, NI_MAXHOST, &svc, NI_MAXSERV, 0);
    if (result)
    {
        std::cout << host << " connected on " << svc << std::endl;
    }
    else
    {
        inet_ntop(AF_INET, &client.sin_addr, &host, NI_MAXHOST);
        std::cout << host << " connected on " << ntohs(client.sin_port) << std::endl;
    }

    // While receiving display message
    char buffer[1024];
    while(true){
        //Clear the buffer
        memset(buffer, 0 ,1024);
        //Wait for a message
        int bytesRecv = recv(clientSocket,buffer,1024,0);
        if(bytesRecv == -1){
            std::cerr << "There was a connection issue" << std::endl;
            break;
        }
        else if(bytesRecv == 0){
            std::cout << "The client disconnected" << std::endl;
            break;
        }

        //Display a message
        std::cout << "Received: " << std::string(buffer,0,bytesRecv) << std::endl;

        //Resend the message
        send(clientSocket,buffer,bytesRecv + 1,0); 
        std::cout << "ye";
    }


    // Close socket
    close(clientSocket);

    return 0;
}