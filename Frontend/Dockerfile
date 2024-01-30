# Use a base image with Node.js
FROM node:14-alpine

# Set the working directory
WORKDIR /usr/src/app

# Copy the necessary files
COPY . .

# Install dependencies
RUN npm install

# Build the React application
RUN npm run build

# Expose port 3000
EXPOSE 3000

# Command to start the application when the container is started
CMD ["npm", "start"]
