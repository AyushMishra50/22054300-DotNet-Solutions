import React from 'react';

class EventExample extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      counter: 0
    };

    // Binding required if not using arrow function
    this.sayWelcome = this.sayWelcome.bind(this);
  }

  increment = () => {
    this.setState(prevState => ({
      counter: prevState.counter + 1
    }));
  };

  decrement = () => {
    this.setState(prevState => ({
      counter: prevState.counter - 1
    }));
  };

  sayHello = () => {
    console.log("Hello! Have a great day.");
  };

  increaseAndGreet = () => {
    this.increment();
    this.sayHello();
  };

  sayWelcome(message) {
    alert("Say Welcome: " + message);
  }

  handleSyntheticEvent = (event) => {
    alert("I was clicked!");
    console.log(event); // Synthetic Event
  };

  render() {
    return (
      <div style={{ padding: '20px' }}>
        <h2>Event Example</h2>
        <p>Counter Value: {this.state.counter}</p>

        <button onClick={this.increaseAndGreet}>Increase</button>
        <button onClick={this.decrement} style={{ marginLeft: '10px' }}>Decrease</button>

        <br /><br />

        <button onClick={() => this.sayWelcome("Welcome to React Events!")}>Say Welcome</button>

        <br /><br />

        <button onClick={this.handleSyntheticEvent}>Synthetic Event Button</button>
      </div>
    );
  }
}

export default EventExample;
