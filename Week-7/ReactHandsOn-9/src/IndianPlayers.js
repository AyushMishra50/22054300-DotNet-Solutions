import React from 'react';

function IndianPlayers() {
  const team = ["Kohli", "Rohit", "Hardik", "Dhoni", "Jadeja", "Shami", "Gill", "Pant"];

  const oddPlayers = team.filter((_, index) => index % 2 !== 0);
  const evenPlayers = team.filter((_, index) => index % 2 === 0);

  // Destructuring example
  const [first, second] = team;

  // Merge arrays
  const T20Players = ["Surya", "Tilak", "Kishan"];
  const RanjiPlayers = ["Pujara", "Rahane"];
  const allPlayers = [...T20Players, ...RanjiPlayers];

  return (
    <div>
      <h2>Indian Team Breakdown</h2>

      <h3>Even Team Players</h3>
      <ul>
        {evenPlayers.map((player, index) => <li key={index}>{player}</li>)}
      </ul>

      <h3>Odd Team Players</h3>
      <ul>
        {oddPlayers.map((player, index) => <li key={index}>{player}</li>)}
      </ul>

      <h3>Merged Team (T20 + Ranji)</h3>
      <ul>
        {allPlayers.map((player, index) => <li key={index}>{player}</li>)}
      </ul>

      <p>Destructured: First - {first}, Second - {second}</p>
    </div>
  );
}

export default IndianPlayers;
