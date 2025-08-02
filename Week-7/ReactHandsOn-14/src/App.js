import React, { useState } from 'react';
import EmployeesList from './EmployeesList';
import ThemeContext from './ThemeContext';

function App() {
  const [theme, setTheme] = useState('light');

  const toggleTheme = () => {
    setTheme(prev => prev === 'light' ? 'dark' : 'light');
  };

  return (
    <ThemeContext.Provider value={theme}>
      <div className="App">
        <h1>Employee Management App</h1>
        <button onClick={toggleTheme}>Toggle Theme</button>

        {/* Remove theme prop */}
        <EmployeesList />
      </div>
    </ThemeContext.Provider>
  );
}

export default App;
