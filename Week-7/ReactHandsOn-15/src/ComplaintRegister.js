import React, { useState } from 'react';

function ComplaintRegister() {
  const [employeeName, setEmployeeName] = useState('');
  const [complaint, setComplaint] = useState('');

  const handleSubmit = (event) => {
    event.preventDefault();
    const refNumber = Math.floor(Math.random() * 100000);
    alert(`Complaint Registered!\nReference No: ${refNumber}\nEmployee: ${employeeName}\nComplaint: ${complaint}`);
    // Optional: reset form
    setEmployeeName('');
    setComplaint('');
  };

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial', maxWidth: '500px', margin: 'auto' }}>
      <h2>Raise a Complaint</h2>
      <form onSubmit={handleSubmit}>
        <div style={{ marginBottom: '10px' }}>
          <label>Employee Name: </label><br />
          <input
            type="text"
            value={employeeName}
            onChange={(e) => setEmployeeName(e.target.value)}
            required
            style={{ width: '100%', padding: '8px' }}
          />
        </div>

        <div style={{ marginBottom: '10px' }}>
          <label>Complaint: </label><br />
          <textarea
            value={complaint}
            onChange={(e) => setComplaint(e.target.value)}
            required
            rows="5"
            style={{ width: '100%', padding: '8px' }}
          />
        </div>

        <button type="submit">Submit</button>
      </form>
    </div>
  );
}

export default ComplaintRegister;
