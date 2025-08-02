import React from 'react';

function ListofPlayers() {
  const players = [
    { name: "Virat", score: 85 },
    { name: "Rohit", score: 40 },
    { name: "Gill", score: 72 },
    { name: "Hardik", score: 60 },
    { name: "Pant", score: 55 },
    { name: "Rahul", score: 90 },
    { name: "Ashwin", score: 35 },
    { name: "Shami", score: 20 },
    { name: "Bumrah", score: 65 },
    { name: "Jadeja", score: 50 },
    { name: "Surya", score: 99 }
  ];

  const below70 = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players</h2>
      <ul>
        {players.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>

      <h2>Players with Score Below 70</h2>
      <ul>
        {below70.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>
    </div>
  );
}

export default ListofPlayers;
