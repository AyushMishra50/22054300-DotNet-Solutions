import React from 'react';

function App() {
  const officeSpaces = [
    {
      name: "Tech Tower",
      rent: 55000,
      address: "Koramangala, Bangalore",
      image: "https://via.placeholder.com/300x150.png?text=Tech+Tower"
    },
    {
      name: "Startup Hub",
      rent: 62000,
      address: "Hitech City, Hyderabad",
      image: "https://via.placeholder.com/300x150.png?text=Startup+Hub"
    },
    {
      name: "Skyview Plaza",
      rent: 48000,
      address: "Salt Lake, Kolkata",
      image: "https://via.placeholder.com/300x150.png?text=Skyview+Plaza"
    }
  ];

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      <h1>Office Space Rental</h1>

      {officeSpaces.map((office, index) => {
        const rentStyle = {
          color: office.rent < 60000 ? 'red' : 'green',
          fontWeight: 'bold'
        };

        return (
          <div key={index} style={{ marginBottom: '30px', border: '1px solid #ccc', padding: '15px', borderRadius: '10px' }}>
            <img src={office.image} alt={office.name} style={{ width: '300px', height: '150px' }} />
            <h2>{office.name}</h2>
            <p><strong>Address:</strong> {office.address}</p>
            <p style={rentStyle}>Rent: ₹{office.rent}</p>
          </div>
        );
      })}
    </div>
  );
}

export default App;
