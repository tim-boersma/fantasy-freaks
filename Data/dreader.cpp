#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
using namespace std;

int main( int argc, char *argv[] ) {
	ifstream ifp;

	if ( argc < 2  ) {
		cout << "File was not entered\n";
		return 2;
	}

	ifp.open( argv[1] );

    if( ! ifp.is_open() ) {
		cout << "File could not be opened\n";
		return 3;
	}

    string team, trash, line;
    float id, val;

    while(getline(ifp, line)) {
        stringstream ss(line);
        getline(ss, trash, ',');
        id = stof(trash);
        getline(ss, team, ',');

        cout << "INSERT INTO defense" << endl;
        cout << "VALUES (" << id << ", '" << team << "'";
        for (int j = 0 ; j < 24 ; j++) {
            getline(ss, trash, ',');
            val = stof(trash);
            cout << ", " << val;
        }
        cout << ");" << endl << endl;
    }
    
	ifp.close();
}