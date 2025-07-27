import React from 'react';
import CohortDetails from './CohortDetails';

function App() {
  return (
    <div>
      <CohortDetails name="React Bootcamp" trainer="John" duration="4 Weeks" status="Ongoing" />
      <CohortDetails name="Node.js Basics" trainer="Jane" duration="3 Weeks" status="Completed" />
    </div>
  );
}

export default App;
