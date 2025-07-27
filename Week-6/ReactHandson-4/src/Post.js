import React from 'react';

class Post extends React.Component {
  render() {
    const { title, body } = this.props;
    return (
      <div>
        <h3>{title}</h3>
        <p>{body}</p>
        <hr />
      </div>
    );
  }
}

export default Post;
