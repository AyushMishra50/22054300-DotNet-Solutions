import React, { Component } from 'react';
import User from './User';
import Guest from './Guest';

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      isLoggedIn: false
    };
  }

  loginHandler = () => {
    this.setState({ isLoggedIn: true });
  };

  logoutHandler = () => {
    this.setState({ isLoggedIn: false });
  };

  render() {
    let content;
    if (this.state.isLoggedIn) {
      content = (
        <div>
          <User />
          <button onClick={this.logoutHandler}>Logout</button>
        </div>
      );
    } else {
      content = (
        <div>
          <Guest />
          <button onClick={this.loginHandler}>Login</button>
        </div>
      );
    }

    return (
      <div className="App" style={{ padding: '20px' }}>
        <h1>Flight Ticket Booking App</h1>
        {content}
      </div>
    );
  }
}

export default App;
