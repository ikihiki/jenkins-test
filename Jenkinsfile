pipeline {
  agent any
  stages {
    stage('install') {
      steps {
        sh 'npm install'
      }
    }
    stage('build') {
      steps {
        sh 'npm run tsc'
      }
    }
    stage('test') {
      steps {
        sh 'npm run test'
      }
    }
  }
}