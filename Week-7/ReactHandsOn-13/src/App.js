import React, { useState } from 'react';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';

function App() {
  const [view, setView] = useState("book");

  const renderComponent = () => {
    if (view === "book") return <BookDetails />;
    if (view === "blog") return <BlogDetails />;
    if (view === "course") return <CourseDetails />;
  };

  return (
    <div style={{ padding: '20px' }}>
      <h1>Blogger App</h1>

      <div>
        <button onClick={() => setView("book")}>Show Books</button>
        <button onClick={() => setView("blog")}>Show Blogs</button>
        <button onClick={() => setView("course")}>Show Courses</button>
      </div>

      {/* Using element variable */}
      {renderComponent()}

      {/* Ternary operator */}
      <div style={{ marginTop: '20px' }}>
        {view === "book"
          ? <p>Currently viewing book details.</p>
          : view === "blog"
          ? <p>Currently viewing blog details.</p>
          : <p>Currently viewing course details.</p>}
      </div>

      {/* Logical && rendering */}
      {view === "course" && <p>These are our top technical courses.</p>}
    </div>
  );
}

export default App;
