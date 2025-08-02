import React from 'react';
import EmployeeCard from './EmployeeCard';

function EmployeesList() {
  const employees = [
    { id: 1, name: "Alice", role: "Engineer" },
    { id: 2, name: "Bob", role: "Designer" },
    { id: 3, name: "Charlie", role: "Manager" }
  ];

  return (
    <div>
      <h2>Employee List</h2>
      {employees.map(emp => (
        <EmployeeCard key={emp.id} employee={emp} />
      ))}
    </div>
  );
}

export default EmployeesList;
