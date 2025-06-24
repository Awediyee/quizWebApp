-- USERS TABLE
CREATE TABLE Users (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(255) UNIQUE NOT NULL,
    password NVARCHAR(255) NOT NULL, -- Store hashed passwords
    first_name NVARCHAR(255) NOT NULL,
    last_name NVARCHAR(255) NOT NULL,
    ImagePath NVARCHAR(255),
    Role NVARCHAR(50) NOT NULL CHECK (Role IN ('Student', 'Admin', 'Teacher')),
    created_at DATETIME DEFAULT GETDATE()
);

-- DEPARTMENTS TABLE
CREATE TABLE Departments (
    department_id INT IDENTITY(1,1) PRIMARY KEY,
    department_name NVARCHAR(255) UNIQUE NOT NULL
);

-- TEACHERS TABLE
CREATE TABLE Teacher (
    user_id INT PRIMARY KEY,
    department_id INT NOT NULL,
    added_by INT,
    FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE,
    FOREIGN KEY (department_id) REFERENCES Departments(department_id) ON DELETE CASCADE,
    FOREIGN KEY (added_by) REFERENCES Users(user_id) ON DELETE NO ACTION
);

-- STUDENTS TABLE
CREATE TABLE Student (
    user_id INT PRIMARY KEY,
    department_id INT NOT NULL,
    added_by INT,
    FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE,
    FOREIGN KEY (department_id) REFERENCES Departments(department_id) ON DELETE CASCADE,
    FOREIGN KEY (added_by) REFERENCES Users(user_id) ON DELETE NO ACTION
);

-- QUIZZES TABLE
CREATE TABLE Quizzes (
    quiz_id INT IDENTITY(1,1) PRIMARY KEY,
    total_questions INT NOT NULL,
    title NVARCHAR(255) UNIQUE NOT NULL,
    department_id INT NOT NULL,
    description NVARCHAR(MAX),
    time_limit INT NOT NULL, -- In minutes
    created_by INT NOT NULL,
    approved_by INT,
    status NVARCHAR(50) NOT NULL CHECK (status IN ('pending', 'approved', 'rejected', 'in_review')) DEFAULT 'pending',
    date_created DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (department_id) REFERENCES Departments(department_id) ON DELETE CASCADE,
    FOREIGN KEY (created_by) REFERENCES Users(user_id) ON DELETE CASCADE,
    FOREIGN KEY (approved_by) REFERENCES Users(user_id) ON DELETE NO ACTION
);

-- QUESTIONS TABLE
CREATE TABLE Questions (
    QuestionID INT IDENTITY(1,1) PRIMARY KEY,
    quiz_id INT NOT NULL,
    QuestionText NVARCHAR(500) NOT NULL,
    QuestionType NVARCHAR(50) NOT NULL CHECK (QuestionType IN ('TrueFalse', 'MultipleChoice')),
    CorrectAnswer NVARCHAR(50) NOT NULL,
    FOREIGN KEY (quiz_id) REFERENCES Quizzes(quiz_id) ON DELETE CASCADE
);

-- QUESTION OPTIONS TABLE
CREATE TABLE QuestionOptions (
    OptionID INT IDENTITY(1,1) PRIMARY KEY,
    QuestionID INT NOT NULL,
    OptionKey CHAR(1) NOT NULL, -- For options like A, B, C, D
    OptionText NVARCHAR(255) NOT NULL,
    UNIQUE (QuestionID, OptionKey),
    FOREIGN KEY (QuestionID) REFERENCES Questions(QuestionID) ON DELETE CASCADE
);

-- RESULTS TABLE
CREATE TABLE Results (
    result_id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT NOT NULL,
    quiz_id INT NOT NULL,
    score INT NOT NULL,
    total_questions INT NOT NULL,
    FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE,
    FOREIGN KEY (quiz_id) REFERENCES Quizzes(quiz_id) ON DELETE NO ACTION -- Changed to NO ACTION
);

-- PETITION TABLE
CREATE TABLE Petition (
    petition_id INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT NOT NULL,
    quiz_id INT NOT NULL,
    msg NVARCHAR(500) NOT NULL,
    status NVARCHAR(50) NOT NULL CHECK (status IN ('open', 'resolved')) DEFAULT 'open',
    resolved_by INT,
    FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE,
    FOREIGN KEY (quiz_id) REFERENCES Quizzes(quiz_id) ON DELETE NO ACTION, -- Changed to NO ACTION
    FOREIGN KEY (resolved_by) REFERENCES Users(user_id) ON DELETE NO ACTION
);