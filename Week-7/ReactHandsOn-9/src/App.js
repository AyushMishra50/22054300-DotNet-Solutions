import React from 'react';
import ListofPlayers from './ListofPlayers';
import IndianPlayers from './IndianPlayers';

function App() {
  const flag = true; // Change to false to test the other component

  return (
    <div className="App">
      {flag ? <ListofPlayers /> : <IndianPlayers />}
    </div>
  );
}

export default App;
