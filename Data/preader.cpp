#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
using namespace std;

void read( ifstream& file, int week) {
	string player, pos, team, trash, line;
    float val;

    while(getline(file, line)) {
        stringstream ss(line);
        getline(ss, player, ',');
        getline(ss, pos, ',');
        getline(ss, team, ',');
        cout << "INSERT INTO Week" << week << "_Players" << endl;
        cout << "VALUES ('" << player << "', '" << pos << "', '" << team << "'";
        for (int j = 0 ; j < 12 ; j++) {
            getline(ss, trash, ',');
            val = stof(trash);
            cout << ", " << val;
        }
        cout << ");" << endl << endl;
    }
}

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

    string line;
    int week;
    getline(ifp, line);
    week = stoi(line);

    read(ifp, week);

	ifp.close();
}
