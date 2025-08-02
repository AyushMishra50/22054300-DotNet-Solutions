import React from 'react';

const blogs = [
  { id: 1, title: "React Basics", author: "Alice" },
  { id: 2, title: "Understanding Hooks", author: "Bob" }
];

function BlogDetails() {
  return (
    <div>
      <h2>Blog Details</h2>
      {blogs.map(blog => (
        <div key={blog.id}>
          <p><strong>{blog.title}</strong> by {blog.author}</p>
        </div>
      ))}
    </div>
  );
}

export default BlogDetails;
